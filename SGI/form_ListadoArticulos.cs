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
    public partial class form_ListadoArticulos : Form
    {
        public form_ListadoArticulos()
        {
            InitializeComponent();
        }

        private void form_ListadoArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.ListarTodos' Puede moverla o quitarla según sea necesario.
            this.ListarTodosTableAdapter.Fill(this.BaseDeDatosDataSet.ListarTodos);

            this.reportViewer1.RefreshReport();
        }
    }
}
