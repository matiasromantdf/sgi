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

namespace SGI
{
    public partial class form_compras : Form
    {
        Proveedor proveedor = new Proveedor();
        Compra compra = new Compra();
        Articulo articulo = new Articulo();
        DetalleCompra detalle = new DetalleCompra();
        Caja caja = new Caja();

        float total=0;
       

        public form_compras()
        {
            InitializeComponent();
            
            
        }

        private void form_compras_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = Convert.ToString(DateTime.Today.ToShortDateString());           
            DataTable datos = proveedor.ObtenerTodos();
            combo_proveedor.DataSource = datos;
            combo_proveedor.DisplayMember = "nombre_proveedor";
            combo_proveedor.ValueMember = "id_proveedor";
            comboBox1.SelectedItem = "A";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            form_busquedaPorNombre f = new form_busquedaPorNombre("compras");
            AddOwnedForm(f);
            f.ShowDialog();
            txt_codigo.Focus();
        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
           
            if (txt_codigo.Text != "")
            {
                
                if (articulo.ExisteArticulo(txt_codigo.Text))
                {
                    articulo = articulo.ListarArticulo(txt_codigo.Text);
                   
                    txt_costo.Text = articulo.Costo_articulo.ToString();
                    txt_precio.Text = articulo.Precio_articulo.ToString();
                    lbl_nombre.Text = articulo.Descr_articulo;
                    lbl_precio.Text = Convert.ToString(articulo.Precio_articulo);
                    lbl_costo.Text = Convert.ToString(articulo.Costo_articulo);
                    lbl_stock.Text = Convert.ToString(articulo.Stock_articulo);

                }
                else
                {
                    MessageBox.Show("No existe artículo con ése Código");
                    txt_codigo.Focus();
                }
            }

            else
            {
                MessageBox.Show("Ingrese el código de un artículo");
            }

        }

        private void button2_Click(object sender, EventArgs e)//nuevo Articulo
        {
            form_NuevoArticulo f = new form_NuevoArticulo();
           
            f.ShowDialog();
           
        }
        private void btn_agregarDetalle_Click(object sender, EventArgs e)
        {
            /* el metodo AgregarDetalle recibe strings y luego
             * los convierte para crear un nuevo objeto DetalleCompra 
             * de la capa Datos.
             * deben estar todos los campos de la clase compra porque construye una
             */
            if (txt_codigo.Text != "" &&
                txt_cantidad.Text != "" &&
                txt_costo.Text != "" &&
                txt_precio.Text != "")
            {
                Articulo articuloNuevo = new Articulo();
                detalle = new DetalleCompra();

                detalle.compra = compra;
                detalle.articulo = articuloNuevo.ListarArticulo(articulo.Cod_articulo);
                detalle.CantCompra = int.Parse(txt_cantidad.Text);
                detalle.Precio = float.Parse(txt_precio.Text);
                detalle.Costo = float.Parse(txt_costo.Text);

                compra.AgregarItemDetalle(detalle);

                LlenarDGV();

            }
            else
                MessageBox.Show("hay campos incompletos");


        }
        private void btn_guardar_Click(object sender, EventArgs e)//boton de Registrar compra
        {
            bool completos = true;
            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is ComboBox) && c.Text == "")
                {
                    completos = false;
                }
            }
            bool cuerpoVacio = true;
            if (txt_total.Text !="")
            {
                cuerpoVacio = false;
            }

            if (completos &!cuerpoVacio)
            {
                //asignamos el proveedor:
                proveedor = proveedor.Listar(Convert.ToInt32(combo_proveedor.SelectedValue.ToString()));

                // si todos los campos estan con datos y el detalle no es vacio
                // asignamos los atributos a la clase compra
                // y registramos:
                compra.proveedor = proveedor;

                proveedor.ActualizarCC(float.Parse(txt_cc.Text) * -1);

                Console.Write(proveedor.Nombre_proveedor);
                compra.Num_factura = txt_numFactura.Text;
                compra.Fecha_compra = Convert.ToDateTime(txt_fecha.Text);
                compra.Total_compra = float.Parse(txt_total.Text);
                compra.Iva_compra = float.Parse(txt_iva.Text);
                                
                compra.Registrar();


                //registramos cada item del detalle de compra
                foreach ( DetalleCompra filaDetalle in compra.Detalle)
                {

                    string result = filaDetalle.Registrar();
                    Console.WriteLine(result);
                    //a cada articulo del detalle de compra
                    //le actualizo el stock, costo, precio y proveedor
                    
                    filaDetalle.articulo.ComprarArticulo(filaDetalle.CantCompra);
                    filaDetalle.articulo.ActualizarCosto(filaDetalle.Costo);
                    filaDetalle.articulo.ActualizarPrecio(filaDetalle.Precio);
                    filaDetalle.articulo.ActualizarProveedor(proveedor);

                }

                
                
                /*actualizo en la caja el disponible para compra (costo)
                 * con el valor que se abona en efectivo 
                 * ya que se resta lo que va a la cuenta corriente del proveedor
                 */
                 
                //actualizo la caja, restando solo lo que se paga en efectivo
                caja.ActualizarCosto(float.Parse(txt_final.Text)*-1);
                caja.ActualizarIva(compra.Iva_compra*-1);

                MessageBox.Show("Compra registrada");
                this.Dispose();


            }
            else
            {
                MessageBox.Show("falta completar algun campo o el cuerpo del detalle está vacío");
            }
        }

       
        private void LlenarDGV()
        {
           // DataTable tablaDetalle = compra.ObtenerTablaDetalle();
            dgv_detalle.Rows.Clear();
            total = 0;
            float iva_comp=0;
            foreach (DetalleCompra det in compra.Detalle)
            {
                dgv_detalle.Rows.Add(
                    det.articulo.Cod_articulo,
                    det.articulo.Descr_articulo,
                    det.CantCompra,
                    det.Costo,
                    det.Precio,
                    det.Costo*det.CantCompra
                    );
                
                iva_comp += ((det.CantCompra * det.Costo)/100)*det.articulo.Iva;
                total += (det.Costo * det.CantCompra);//+iva_comp;
            }
            txt_total.Text =(total+iva_comp).ToString();
            txt_iva.Text = iva_comp.ToString();
            if (comboBox1.Text == "C") txt_iva.Text = "";
            txt_final.Text = Convert.ToString((total+iva_comp) - float.Parse(txt_cc.Text));
        }

        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==6)
            {
                compra.EliminarItemDetalle(e.RowIndex);
                LlenarDGV();
            }
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {/*
            double aux = Convert.ToDouble(txt_costo.Text,
               System.Globalization.CultureInfo.InvariantCulture);
            txt_costo.Text = string.Format("{0:f2}", aux);
            */
            txt_costo.Text = txt_costo.Text.Replace(".", ",");
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {/*
            double aux = Convert.ToDouble(txt_precio.Text,
               System.Globalization.CultureInfo.InvariantCulture);
            txt_precio.Text = string.Format("{0:f2}", aux);
        */
            txt_precio.Text = txt_precio.Text.Replace(".", ",");
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_numFactura_KeyPress(object sender, KeyPressEventArgs e)
        {  //solo permite ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_inversion f = new form_inversion();
            f.ShowDialog();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar!=',');
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txt_cc_TextChanged(object sender, EventArgs e)
        {
            LlenarDGV();
        }
    }
}
