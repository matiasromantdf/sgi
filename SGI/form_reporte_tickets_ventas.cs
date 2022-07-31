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
    public partial class form_reporte_tickets_ventas : Form
    {
        Venta venta = new Venta();
        public form_reporte_tickets_ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = venta.ListarTickets(fecha_desde.Value, fecha_hasta.Value, (checkBox1.Checked) ? true : false);
        }
    }
}
