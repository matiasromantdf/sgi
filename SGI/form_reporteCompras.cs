using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class form_reporteCompras : Form
    {
        public form_reporteCompras()
        {
            InitializeComponent();
        }

        private void form_reporteCompras_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.reporCompras' Puede moverla o quitarla según sea necesario.
            this.reporComprasTableAdapter.Fill(this.BaseDeDatosDataSet.reporCompras,fecha1.Value,fecha2.Value);

            this.reportViewer1.RefreshReport();

        }
    }
}
