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
    public partial class form_resporCC : Form
    {
        Proveedor proveedor = new Proveedor();
        public form_resporCC()
        {
            InitializeComponent();
        }

        private void form_resporCC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.listarDeuda' Puede moverla o quitarla según sea necesario.
            this.listarDeudaTableAdapter.Fill(this.BaseDeDatosDataSet.listarDeuda);
            comboBox1.DataSource = proveedor.ObtenerTodos();
            comboBox1.DisplayMember = "nombre_proveedor";
            comboBox1.ValueMember = "id_proveedor";

            this.reportViewer2.RefreshReport();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedValue;
            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.reportCCproveedor1' Puede moverla o quitarla según sea necesario.
            this.reportCCproveedor1TableAdapter.Fill(this.BaseDeDatosDataSet.reportCCproveedor1,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
