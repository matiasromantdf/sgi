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
    public partial class form_ReporteReposicion : Form
    {
        Proveedor proveedor;
        
        public form_ReporteReposicion()
        {
            InitializeComponent();
        }

        private void form_ReporteReposicion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.Reposicion' Puede moverla o quitarla según sea necesario.
            proveedor = new Proveedor();
            comboProveedor.DataSource = proveedor.ObtenerTodos();
            comboProveedor.DisplayMember = "nombre_proveedor";
            comboProveedor.ValueMember = "id_proveedor";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReposicionTableAdapter.Fill(this.BaseDeDatosDataSet.Reposicion,(int)comboProveedor.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
