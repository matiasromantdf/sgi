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

namespace SGI
{
    public partial class form_bajaArticulo : Form
    {
        Articulo articulo = new Articulo();
        Bajas baja = new CapaDatos.Bajas();
        public form_bajaArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_busquedaPorNombre f = new form_busquedaPorNombre("bajas");
            AddOwnedForm(f);
            f.ShowDialog();
            txt_codigo.Focus();
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {
                if (articulo.ExisteArticulo(txt_codigo.Text))
                {
                    articulo = articulo.ListarArticulo(txt_codigo.Text);
                    lbl_NombreDeArt.Text = articulo.Descr_articulo;
                    lbl_stock.Text = articulo.Stock_articulo.ToString();
                }
                else
                {
                    MessageBox.Show("No existe artículo con ése Código");
                    txt_codigo.Focus();
                }
            }

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            baja.codigoDeArticulo = txt_codigo.Text;
            baja.detalle = txt_motivo.Text;
            baja.cantidad = Convert.ToInt32(txt_cantidad.Text);
            baja.fecha = txt_fecha.Value;
            string result=baja.Registrar();
            MessageBox.Show(articulo.RegistrarBaja(Convert.ToInt32(txt_cantidad.Text)));
            MessageBox.Show(result);
            this.Dispose();
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_cantidad.Text)>Convert.ToInt32(lbl_stock.Text))
            {
                MessageBox.Show("la cantidad ingresada es mayot al stock");
                txt_cantidad.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
