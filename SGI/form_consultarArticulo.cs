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
        
    public partial class form_consultarArticulo : Form
    {
        Articulo articulo = new Articulo();
        Proveedor proveedor = new Proveedor();
        public form_consultarArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_busquedaPorNombre f = new form_busquedaPorNombre("consulta");
            AddOwnedForm(f);
            f.ShowDialog();
            txt_codigo.Focus();
            SendKeys.Send("{TAB}");
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {
                if (articulo.ExisteArticulo(txt_codigo.Text))
                {
                    articulo = articulo.ListarArticulo(txt_codigo.Text);
                    txt_nombre.Text = articulo.Descr_articulo;
                    txt_precio.Text = articulo.Precio_articulo.ToString();
                    txt_iva.Text = articulo.Iva.ToString();
                    txt_stock.Text = articulo.Stock_articulo.ToString();
                    txt_costo.Text = articulo.Costo_articulo.ToString();
                    txt_minimo.Value = articulo.Stock_minimo;
                    proveedor = proveedor.Listar(articulo.Prov.Id_proveedor);
                    combo_prov.DataSource = proveedor.ObtenerTodos();
                    combo_prov.DisplayMember = "nombre_proveedor";
                    combo_prov.ValueMember = "id_proveedor";
                    combo_prov.SelectedValue = articulo.Prov.Id_proveedor;
                    
                 }
                else
                {
                    MessageBox.Show("No existe artículo con ése Código");
                    txt_codigo.Focus();
                }
            }
        }

        private void form_consultarArticulo_Load(object sender, EventArgs e)
        {
            if (Program.user != "admin")
            {
                lbl_costo.Visible = false;
                txt_costo.Visible = false;
                btn_editar.Visible = false;
                btn_guardar.Visible = false;

            }
            foreach(Control c in Controls)
            {
                if(c is NumericUpDown )
                {
                    c.Enabled = false;                   
                }
            }
            combo_prov.Enabled = false;
            txt_nombre.Enabled = false;
            btn_retirar.Enabled = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_nombre.Enabled = true;
            foreach (Control c in Controls)
            {
                if (c is NumericUpDown && c.Name != "txt_stock")
                {
                    
                   c.Enabled = true;

                }
            }
            btn_retirar.Enabled = true;
            combo_prov.Enabled = true;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(txt_stock, "No se puede modificar el stock en esta ventana");
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            articulo.ActualizarDescripcion(txt_nombre.Text);
            articulo.ActualizarCosto(float.Parse(txt_costo.Text));
            articulo.ActualizarPrecio(float.Parse(txt_precio.Text));
            articulo.ActualizarProveedor(proveedor.Listar((int)combo_prov.SelectedValue));
            articulo.ActualizarIva(float.Parse(txt_iva.Text));
            articulo.ActualizarMinimo((int)txt_minimo.Value);
            MessageBox.Show("Articulo editado correctamente");
            Dispose();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            txt_precio.Text = txt_precio.Text.Replace(".", ",");
        }

        private void txt_costo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            txt_costo.Text = txt_costo.Text.Replace(".", ",");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txt_nombre.Text.EndsWith("DISCONTINUADO"))
            {
                txt_nombre.Text = txt_nombre.Text + "-DISCONTINUADO-";
            }
        }
    }
}
