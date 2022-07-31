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
    public partial class form_stck_valuado : Form
    {
        Articulo art = new Articulo();

        public form_stck_valuado()
        {
            InitializeComponent();
        }

        private void form_stck_valuado_Load(object sender, EventArgs e)
        {
            label1.Text = art.ReporteValuado().ToString();
        }
    }
}
