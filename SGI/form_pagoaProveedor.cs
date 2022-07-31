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
    
    public partial class form_pagoaProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        Caja caja = new Caja();
        Pagos pagos = new CapaDatos.Pagos();

        public form_pagoaProveedor()
        {
            InitializeComponent();
        }

        private void form_pagoaProveedor_Load(object sender, EventArgs e)
        {
            combo_proveedor.DataSource = proveedor.ObtenerTodos();
            combo_proveedor.ValueMember = "id_proveedor";
            combo_proveedor.DisplayMember = "nombre_proveedor";
        }

        private void combo_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            proveedor = proveedor.Listar((int)combo_proveedor.SelectedValue);
            lbl_cc.Text = proveedor.Cc_proveedor.ToString();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            proveedor.ActualizarCC(float.Parse(txt_monto.Text));
            caja.ActualizarCosto(float.Parse(txt_monto.Text) * -1);//actualizo la caja, va en negativo
            pagos.fecha = txt_fecha.Value;
            pagos.idProveedor = proveedor.Id_proveedor;
            pagos.monto = float.Parse(txt_monto.Text);
            pagos.comprobante = txt_comprobante.Text;
            pagos.Registrar();
            MessageBox.Show("Registrado correctamente");
            Dispose();
        }

        private void txt_monto_Leave(object sender, EventArgs e)
        {
            txt_monto.Text = txt_monto.Text.Replace(".", ",");
        }
    }
}
