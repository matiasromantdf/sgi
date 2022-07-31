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
    public partial class form_inversion : Form
    {
        Caja caja;
        public form_inversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de registrar el ingreso?", "Confirmar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    float monto = float.Parse(txtMonto.Text);
                    caja = new Caja();
                    caja.ActualizarCosto(monto);
                    txtMonto.Text = "";
                    MessageBox.Show("Registrado correctamente");
                    Dispose();
                }
                else
                {
                    txtMonto.Focus();
                }
            }
            else
                MessageBox.Show("Debe ingresar un valor");
        }

    }
}
