﻿using System;
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
    
    public partial class form_crearVendedor : Form
    {
        Login login = new Login();
        public form_crearVendedor()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (txt_pass.Text == txt_pass2.Text & txt_pass.Text.Length > 5)
            {
                string result = login.CrearUsuario(txt_nombre.Text, txt_pass2.Text,"ventas");
                MessageBox.Show("se ha insertado" + result + " registro");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error: las contraseñas son distintas o menor a 6 letras");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

     

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length < 6)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dispose();

        }
    }
}
