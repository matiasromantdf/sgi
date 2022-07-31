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
    public partial class form_NuevoArticulo : Form
    {
        Proveedor proveedor=new Proveedor();
        Articulo articulo=new Articulo(); 

        public form_NuevoArticulo()
        {
            InitializeComponent();
        }
        private void LlenarCombo()
        {
            combo_proveedor.DataSource = proveedor.ObtenerTodos();
            combo_proveedor.DisplayMember = "nombre_proveedor";
            combo_proveedor.ValueMember = "id_proveedor";
        }
        private void form_NuevoArticulo_Load(object sender, EventArgs e)
        {
            LlenarCombo();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool completos = true;

            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is ComboBox) && c.Text == "")
                {
                    completos = false;
                }
            }
            if (completos)
            {
                if (articulo.ExisteArticulo(txt_cod.Text))
                {
                    MessageBox.Show("ya existe el código ingresado");

                }
                else {
                    // si estan todos los campos completos se realiza el registro
                    articulo.Cod_articulo = txt_cod.Text;
                    articulo.Prov =proveedor.Listar(((int)combo_proveedor.SelectedValue));//listamos el proveedor segun el id
                    articulo.Descr_articulo = txt_descripcion.Text;
                    articulo.Costo_articulo = float.Parse(txt_costo.Text);
                    articulo.Precio_articulo = float.Parse(txt_precio.Text);
                    articulo.Iva = float.Parse(txt_iva.Text);
                    articulo.Stock_minimo = (int)txt_minimo.Value;

                    string result = articulo.Registrar();
                    MessageBox.Show(result);
                    Dispose();
                }
            }
            else MessageBox.Show("falta completar algun campo");
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            txt_costo.Text = txt_costo.Text.Replace(".", ",");
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            txt_precio.Text=txt_precio.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_NuevoProveedor f = new form_NuevoProveedor();
            f.ShowDialog();

        }

        private void combo_proveedor_Enter(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '.');
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '.');
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '.');
        }
    }
    }

