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
    public partial class form_pagoIva : Form
    {
        CapaDatos.Caja caja = new Caja();
        public form_pagoIva()
        {
            InitializeComponent();
        }

        private void form_pagoIva_Load(object sender, EventArgs e)
        {
            lbl_monto.Text = caja.Iva.ToString("C");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caja.ActualizarIva((float)txt_monto.Value * -1) == "correcto")
            {
                MessageBox.Show("Se registro correctamente el pago IVA");
            }
            else
                MessageBox.Show("hubo problemas al acceder a la Base de Datos");
            Dispose();

        }
    }
}
