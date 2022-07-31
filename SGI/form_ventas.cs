using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using facturar;
using QRCoder;
using System.Web;
using Newtonsoft.Json;
using System.Globalization;

namespace SGI

{
    public partial class form_ventas : Form
    {
        Imprimir imprime; 
        Venta venta;
        Articulo articulo;
        DetalleVenta itemNuevo;
        Comercio comercio;
        CultureInfo ci = new CultureInfo("es-AR");
        double iva_21 = 0;
        double iva_105 = 0;
        double base_21 = 0;
        double base_105 = 0;
        double neto = 0;

        public void Inicializar() {

        }

        public form_ventas()
        {
            venta = new Venta();
            articulo = new Articulo();
            InitializeComponent();
            comercio = new Comercio();
            imprime = new Imprimir();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void btn_agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btn_agregar_Click(this, e);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        //boton de agragar a detalle. veirifica primero si el item ya existe
        {
            if (txt_codigo.Text != "" && txt_cant.Text != "")
            {

                int cant = Convert.ToInt32(txt_cant.Text);
                float subt = articulo.Precio_articulo * cant * ((articulo.Iva / 100) + 1);
                bool existeEnElDetalle = false;

                Articulo articuloNuevo = new Articulo();
                articuloNuevo = articuloNuevo.ListarArticulo(articulo.Cod_articulo);


                itemNuevo = new DetalleVenta(cant, subt, venta, articuloNuevo);

                foreach (DetalleVenta det in venta.detalle)
                {
                    if (det.articulo.Cod_articulo == itemNuevo.articulo.Cod_articulo)
                    {
                        det.Cantidad += itemNuevo.Cantidad;
                        det.Subtotal = det.articulo.Precio_articulo * det.Cantidad * ((articulo.Iva / 100) + 1);
                        venta.Calcular();
                        existeEnElDetalle = true;
                    }
                }
                if (existeEnElDetalle == false)
                {
                    venta.AgregarItemAlDetalle(itemNuevo);
                }
                txt_cant.Text = "1";

                LlenarDGV();

            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
            txt_codigo.Focus();
            txt_codigo.Text = "";
            lbl_NombreDeArt.Text = "";
            lbl_Precio.Text = "";
        }
        private void LlenarDGV()
        {
            iva_105 = 0;
            base_105 = 0;
            iva_21 = 0;
            base_21 = 0;
            datagrid_detalle.Rows.Clear();

            foreach (DetalleVenta det in venta.detalle)
            {
               
                datagrid_detalle.Rows.Add(
                    det.articulo.Cod_articulo,
                    det.articulo.Descr_articulo,
                    det.Cantidad,
                    det.articulo.Precio_articulo,
                    ((det.articulo.Precio_articulo /100) * det.articulo.Iva),
                    det.Subtotal
                    );
                if (det.articulo.Iva == 21)
                {
                    iva_21 += det.Cantidad * (det.articulo.Precio_articulo / 100) * det.articulo.Iva;
                    base_21 += det.Cantidad * det.articulo.Precio_articulo;
                }
                if (det.articulo.Iva == 10.5)
                {
                    iva_105 += det.Cantidad * (det.articulo.Precio_articulo / 100) * det.articulo.Iva;
                    base_105 += det.Cantidad * det.articulo.Precio_articulo;
                }
            }

            ActualizarTotal();
            txt_105.Text = iva_105.ToString("c",ci);
            txt_21.Text = iva_21.ToString("c", ci);
        }
        private void button1_Click(object sender, EventArgs e)//boton de busqueda por nombre
        {
            BuscarPorNombre();
        }
        private void BuscarPorNombre()
        {

            form_busquedaPorNombre f = new form_busquedaPorNombre("ventas");
            AddOwnedForm(f);
            f.ShowDialog();
            txt_codigo.Focus();
        }
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)//evento tecla f2 para buscar por nombre
        {
            if (e.KeyCode == Keys.F2)
            {
                BuscarPorNombre();
            }
        }

        private void form_ventas_Load(object sender, EventArgs e)// carga el numero de venta segun la ultima venta grabada en la bd
        {
            txt_num_venta.Text = Convert.ToString(venta.IdVenta);
            fecha.Value = venta.FechaVenta;

        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {
                if (articulo.ExisteArticulo(txt_codigo.Text))
                {
                    articulo = articulo.ListarArticulo(txt_codigo.Text);
                    lbl_NombreDeArt.Text = articulo.Descr_articulo;
                    lbl_Precio.Text = Convert.ToString(articulo.Precio_articulo);
                }
                else
                {
                    MessageBox.Show("No existe artículo con ése Código");
                    txt_codigo.Focus();
                }
            }


        }

        private void datagrid_detalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        /*luego de modificar cantidad en el 
        DGV se actualiza el objeto en capa negocio, luego se actualiza el DGV
        */
        {/*
            if (e.RowIndex > -1)
            {
                if (Convert.ToInt32(datagrid_detalle.Rows[e.RowIndex].Cells["cantidad"].Value) < 1)
                {
                    venta.EliminarItem(e.RowIndex);
                    LlenarDGV();
                    txt_codigo.Focus();
                }
                else
                {
                    venta.CambiarCantidadDetalle(e.RowIndex, Convert.ToInt32(datagrid_detalle.Rows[e.RowIndex].Cells["cantidad"].Value));
                    LlenarDGV();
                    txt_codigo.Focus();
                }
            }
            ActualizarTotal();*/
        }

        private void ActualizarTotal()
        {
            float tot = venta.Bruto;// + venta.Iva;
            txt_total.Text = Math.Round(Convert.ToDecimal(tot),2).ToString();
            neto = venta.Bruto;//arreglar en el futuro
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrareImprimir();
        }

        private void datagrid_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                venta.EliminarDetalleItem(e.RowIndex);
                LlenarDGV();
            }
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

        private void RegistrareImprimir()
        {
            venta.Cliente = txt_cliente.Text;
            if (venta.Bruto > 0)
            {
                venta.Bruto = float.Parse(txt_total.Text);
                venta.Registrar(); // se registra la venta y se procesa cada articulo
                MessageBox.Show("Venta registrada, ticket: " + venta.IdVenta);
                foreach (DetalleVenta det in venta.detalle)
                {
                    det.Registrar();
                }

               
            }
            else
                MessageBox.Show("No hay nada que registrar!");

            
            imprime.AddHeaderLine(comercio.nombre);
            imprime.AddSubHeaderLine("C.U.I.T.: " + comercio.cuit);
            imprime.AddSubHeaderLine("Dirección: "+comercio.direccion);
            imprime.AddSubHeaderLine("IIBB: "+comercio.iibb);
            

            foreach (DetalleVenta det in venta.detalle)
            {
                imprime.AddItem(det.Cantidad.ToString(), "($" + Math.Round( det.articulo.Precio_articulo * ((det.articulo.Iva / 100) + 1),2) +") "+ det.articulo.Descr_articulo, det.Subtotal.ToString("C",ci));
            }

           // imprime.AddTotal("IVA = ",venta.Iva.ToString("C",ci));
            imprime.AddTotal("Total= ", venta.Bruto.ToString("C",ci));

            imprime.PrintTicket();
            imprime.PrintTicket();//imprime dos veces

            Form nuevo = new form_ventas(); //se crea un nuevo from para reinicializar
            nuevo.Show();
            this.Dispose();

        }
        private void PrepararFactura()
        {
            
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            factura fact = new factura(txt_cliente.Text);
            fact.puntoDeVenta = comercio.punto_venta;
            fact.fecha_factura = venta.FechaVenta;
            fact.total_factura = Convert.ToDouble(venta.Bruto);

            fact.base_105 = base_105;
            fact.iva_105 = iva_105;
            fact.base_21 = base_21;
            fact.iva_21 = iva_21;
            fact.neto = venta.Bruto;


            //finalmente realizar la peticion:
            fact.RealizarPeticion();
            
           

            string caeObtenido = fact.DevolverCae(); //si hay error el cae viene en blanco

            if(caeObtenido !="") // si no hay cae por algun error no se imprime el QR
            {
                DatosParaQR cadenaQr = new DatosParaQR();
                cadenaQr.Fecha = DateTime.Today;
                cadenaQr.Cuit = comercio.cuit;
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
                imprime.AddInfoCAE("C.A.E.: "+caeObtenido);
                var ci = new CultureInfo("es-ES");
                DateTime  fechaVenc = DateTime.ParseExact(fact.DevolverFechaVenc(), "yyyyMMdd",ci);
                imprime.AddInfoCAE("vencimiento C.A.E.: "+fechaVenc.ToString("dd/MM/yyyy"));

                venta.Cae = caeObtenido;
                venta.VenCae = fechaVenc;
                venta.Cliente = txt_cliente.Text;
                venta.Factura = Convert.ToString( fact.vUltimoRecibo);
                venta.TipoFactura = comercio.cod_factura;
                venta.PuntoVenta = Convert.ToString(comercio.punto_venta);

            }

            RegistrareImprimir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
