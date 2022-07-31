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
    public partial class CrearAdmin : Form
    {
        Login login = new Login();
        public CrearAdmin()
        {
            InitializeComponent();
            lbl_aviso.Visible = false;
        }

        private void CrearAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text==txt_pass2.Text & txt_pass.Text.Length>5)
            {
                string result= login.CrearUsuario(txt_nombre.Text, txt_pass2.Text,"admin");
                MessageBox.Show("se ha insertado" + result + " registro");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error: las contraseñas son distintas o menor a 6 letras");
            }
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length < 6)
            {
                lbl_aviso.Visible = true;
            }
            else
            {
                lbl_aviso.Visible = false;
            }
        }
    }
}
