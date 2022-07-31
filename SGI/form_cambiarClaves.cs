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
    public partial class form_cambiarClaves : Form
    {
        Login login = new Login();
        public form_cambiarClaves()
        {
            InitializeComponent();
        }

        private void form_cambiarClaves_Load(object sender, EventArgs e)
        {
            combo_nombres.DataSource = login.ListarUsuarios();
            combo_nombres.DisplayMember = "usuario";
            combo_nombres.ValueMember = "usuario";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (txt_pass.Text == txt_pass2.Text & txt_pass.Text.Length > 5)
            {
                string result = login.ActualizarClave(combo_nombres.SelectedValue.ToString(),txt_pass.Text);
                MessageBox.Show(result);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error: las contraseñas son distintas o menor a 6 letras");
            }
        }
    }
}
