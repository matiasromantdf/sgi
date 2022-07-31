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
    public partial class form_NuevoProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        public form_NuevoProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          if(proveedor.Registrar(txtNombre.Text, txtTel.Text, txtCuit.Text) == "correcto")
            {
                MessageBox.Show("Se registró correctamente el Proveedor");
                Dispose();
            }
            else
            {
                MessageBox.Show("Error. El CUIT ya está registrado!");
            }
            
            
        }
    }
}
