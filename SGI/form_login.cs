using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Management;

namespace SGI
{
    public partial class form_login : Form
    {
         Login login = new Login();
        
         Comercio comercio = new Comercio();

        public form_login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {                     

            if (EstaRegistrado() && login.ObtenerRol(txt_user.Text, txt_pass.Text)!="datos erroneos" )
            {

                MessageBox.Show("Ingreso al sistema con rol: "+login.ObtenerRol(txt_user.Text, txt_pass.Text));
                Principal p = new Principal(login.Rol);
                p.Show();
                Program.user = login.Rol;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de sesión o sistema sin registrar");
            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string ObtenerIDdisco()
        {
            string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }
        private string ObtenerLicencia()
        {
            return comercio.licencia;
            
        }

        private bool EstaRegistrado()
        {
            if (Seguridad.Encriptar(ObtenerIDdisco()) == comercio.licencia || Program.esVersionDePrueba)
            {
                return true;
            }

              else  return false;
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            if (EstaRegistrado() || Program.esVersionDePrueba)
            {
                txt_user.Focus();

                if (login.SinUsuarios())
                {
                    CrearAdmin crear = new CrearAdmin();
                    crear.ShowDialog();
                }

            }
            else
            {
                registrar r = new registrar();
                r.ShowDialog();
            }

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (login.SinUsuarios())
            {
                CrearAdmin crear = new CrearAdmin();
                crear.ShowDialog();
            }
        }
    }
}
