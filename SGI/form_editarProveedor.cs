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
    public partial class form_editarProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        public form_editarProveedor()
        {
            InitializeComponent();
        }

        private void form_editarProveedor_Load(object sender, EventArgs e)
        {
            cmb_proveedores.DataSource = proveedor.ObtenerTodos();
            cmb_proveedores.DisplayMember = "nombre_proveedor";
            cmb_proveedores.ValueMember = "id_proveedor";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_proveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            proveedor = proveedor.Listar((int)cmb_proveedores.SelectedValue);
            txt_cuit.Text = proveedor.Cuit_proveedor;
            txt_nombre.Text = proveedor.Nombre_proveedor;
            txt_telefono.Text = proveedor.Telefono_proveedor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result= proveedor.EditarProveedor(txt_nombre.Text,txt_telefono.Text,txt_cuit.Text);
            if (result == "correcto") MessageBox.Show("Se actualizaron los datos");
            else
            {
                MessageBox.Show(result);
            }
            
            Dispose();
        }
    }
}
