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
    public partial class form_DatosComercio : Form
    {
        CapaDatos.Comercio comercio;
        public form_DatosComercio()
        {
            InitializeComponent();
             comercio = new Comercio();
            txt_cuit.Text = comercio.cuit;
            txt_direccion.Text = comercio.direccion;
            txt_iibb.Text = comercio.iibb;
            txt_nombre.Text = comercio.nombre;
            txt_ptoventa.Value = comercio.punto_venta;
            txt_codfact.Value = Convert.ToDecimal(comercio.cod_factura);
            txt_pag.Text = comercio.pagina;
            txt_tel.Text = comercio.telefono;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            DialogResult pregunta = MessageBox.Show("Actualizar los datos?", "Atención!", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
               res = comercio.actualizarDatos(txt_nombre.Text, txt_direccion.Text, txt_cuit.Text,Convert.ToString (txt_codfact.Value), Convert.ToInt32( txt_ptoventa.Value), txt_iibb.Text, txt_tel.Text,txt_pag.Text);
            }

            MessageBox.Show(res);
            this.Dispose();
        }

        private void form_DatosComercio_Load(object sender, EventArgs e)
        {

        }
    }
}
