using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using facturar;
using Newtonsoft.Json;
using QRCoder;

namespace SGI
{
    public partial class ImprimirFacturas : Form
    {
        Venta venta = new Venta();
        DetalleVenta detalle = new DetalleVenta();
        Imprimir imprime = new Imprimir();

        public ImprimirFacturas()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void TraerDatos(int cod)
        {
            venta = venta.Listar(cod);

            if (venta.Bruto > 0)
            {

                lbl_fecha.Text = venta.FechaVenta.ToString();
                
                lbl_cliente.Text = venta.Cae;
                dgv.DataSource = detalle.ListarDetalle(cod);

                lbl_total.Text = venta.Bruto.ToString();
                txt_cliente.Text = venta.Cliente;

            }
            else
            {
                MessageBox.Show("El numero de venta ingresado no es válido");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TraerDatos((int)numericUpDown1.Value);
        }

        private class DatosParaQR
        {
            int ver = 1;
            DateTime fecha;
            string cuit;
            int ptoVta;
            int tipoCmp;
            int nroCmp;
            float importe;
            string moneda = "PES";
            int ctz = 1;
            string tipoCodAut;
            string codAut;

            public string Cuit { get => Cuit1; set => Cuit1 = value; }
            public int Ver { get => ver; set => ver = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public string Cuit1 { get => cuit; set => cuit = value; }
            public int PtoVta { get => ptoVta; set => ptoVta = value; }
            public int TipoCmp { get => tipoCmp; set => tipoCmp = value; }
            public int NroCmp { get => nroCmp; set => nroCmp = value; }
            public float Importe { get => importe; set => importe = value; }
            public string Moneda { get => moneda; set => moneda = value; }
            public int Ctz { get => ctz; set => ctz = value; }
            public string TipoCodAut { get => tipoCodAut; set => tipoCodAut = value; }
            public string CodAut { get => codAut; set => codAut = value; }
        }
        public static Bitmap resizeImage(Image imgToResize, Size size)
        {
            return (new Bitmap(imgToResize, size));
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbl_cliente.Text != " " )
            {
                Comercio comercio = new Comercio();
                factura fact = new factura(txt_cliente.Text);
                fact.puntoDeVenta = comercio.punto_venta;
                fact.fecha_factura = venta.FechaVenta;
                fact.total_factura = Convert.ToDouble(venta.Bruto + venta.Iva);

                fact.base_105 = Math.Round(venta.base_105);
                fact.iva_105 = Math.Round(venta.iva_105);
                fact.base_21 = Math.Round(venta.base_21);
                fact.iva_21 = Math.Round(venta.iva_21);
                fact.neto = Math.Round(venta.Bruto, 2)-fact.iva_105-fact.iva_21;


                //finalmente realizar la peticion:
                fact.RealizarPeticion();



                string caeObtenido = fact.DevolverCae(); //si hay error el cae viene en blanco
                string numfactura = fact.vUltimoRecibo.ToString();

                if (caeObtenido != "") // si no hay cae por algun error no se imprime el QR
                {
                    DatosParaQR cadenaQr = new DatosParaQR();
                    cadenaQr.Fecha = DateTime.Today;
                    cadenaQr.Cuit = "20292131500";
                    cadenaQr.PtoVta = comercio.punto_venta;
                    cadenaQr.TipoCmp = int.Parse(comercio.cod_factura);
                    cadenaQr.CodAut = caeObtenido;
                    cadenaQr.Importe = venta.Bruto;

                    string jsondelqr = JsonConvert.SerializeObject(cadenaQr);


                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData datos = qr.CreateQrCode("https://www.afip.gob.ar/fe/qr/?p=" + Base64Encode(jsondelqr), QRCodeGenerator.ECCLevel.Q);
                    QRCode qrcode = new QRCode(datos);

                    Bitmap imgqr = qrcode.GetGraphic(20);
                    imgqr = resizeImage(imgqr, new Size(150, 150));
                    imprime.HeaderImage = imgqr;
                    imprime.AddInfoCAE("C.A.E.: " + caeObtenido);
                    var ci = new CultureInfo("es-ES");
                    DateTime fechaVenc = DateTime.ParseExact(fact.DevolverFechaVenc(), "yyyyMMdd", ci);
                    imprime.AddInfoCAE("vencimiento C.A.E.: " + fechaVenc.ToString("dd/MM/yyyy"));

                    venta.Cae = caeObtenido;
                    venta.VenCae = fechaVenc;
                    venta.Cliente = txt_cliente.Text;
                    venta.Factura = Convert.ToString(fact.vUltimoRecibo);
                    venta.TipoFactura = comercio.cod_factura;
                    venta.PuntoVenta = Convert.ToString(comercio.punto_venta);
                    venta.ActualizarFiscal(venta.Factura, venta.Cae, venta.VenCae,comercio.punto_venta, venta.IdVenta);
                    //comienza a imprimir

                    imprime.AddHeaderLine(comercio.nombre);
                    imprime.AddSubHeaderLine("C.U.I.T.: " + comercio.cuit);
                    imprime.AddSubHeaderLine("Dirección: " + comercio.direccion);
                    imprime.AddSubHeaderLine("IIBB: " + comercio.iibb);

                    foreach (DataGridViewRow fila in dgv.Rows)
                    {
                        imprime.AddItem(fila.Cells["cantidad"].Value.ToString(), "($" + fila.Cells["precio"].Value.ToString() + ") " + fila.Cells["descripcion"].Value.ToString(), fila.Cells["subtotal"].Value.ToString());

                    }
                    imprime.AddTotal("Total= ", venta.Bruto.ToString());

                    imprime.PrintTicket();                                                                          

                    TraerDatos((int)numericUpDown1.Value);


                }
                else
                {
                    MessageBox.Show("Hubo un error al conectar...");
                }

                

            }
            else
            {
                MessageBox.Show("Ésta venta ya tiene CAE");
            }
            
        }
    }
}
