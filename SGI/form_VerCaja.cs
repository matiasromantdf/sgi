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
    public partial class form_VerCaja : Form
    {
        Caja caja = new Caja();
        
        public form_VerCaja()
        {
            InitializeComponent();
        }

        private void form_VerCaja_Load(object sender, EventArgs e)
        {
            caja.ObtenerValores();
            lblTotal.Text = (caja.ImporteGanancia + caja.ImporteCosto + (caja.Iva > 0 ? caja.Iva : 0)).ToString("C");
            lblCosto.Text = caja.ImporteCosto.ToString("C");
            lblGanancia.Text = caja.ImporteGanancia.ToString("C");
           

            
            lblIva.Text = caja.Iva.ToString("C");
        }
    }
}
