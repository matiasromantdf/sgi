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
    public partial class form_reporte_ventas : Form
    {
        public form_reporte_ventas()
        {
            InitializeComponent();
        }

        private void form_reporte_ventas_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime desde,hasta;
            desde = fecha_desde.Value;
            hasta = fecha_hasta.Value;
            
            
            this.ventaporfechasTableAdapter.Fill(this.BaseDeDatosDataSet.ventaporfechas,desde,hasta);

            this.reportViewer1.RefreshReport();

        }
    }
}
