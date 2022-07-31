using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CapaDatos;
using System.Management;


namespace SGI
{
    public partial class registrar : Form
    {
        private Boolean esPrueba = false;
        private Boolean activo = true;
        private DateTime fecha;

        Comercio comercio = new Comercio();
        
        public registrar()
        {
            InitializeComponent();
        }

        private class Objeto
        {
            string cliente;
            string contacto;
            string serial;
            string activo;
            string es_prueba;
            string fecha;

            public string Cliente { get => cliente; set => cliente = value; }
            public string Contacto { get => contacto; set => contacto = value; }
            public string Serial { get => serial; set => serial = value; }
            public string Activo { get => activo; set => activo = value; }
            public string Es_prueba { get => es_prueba; set => es_prueba = value; }
            public string Fecha { get => fecha; set => fecha = value; }
        }

        private void ObtenerAPI(string id)
        {
            var url = $"https://arduino.elgranero.net/sgi-consultar.php?serial={id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return ;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);

                           
                            var result = JsonConvert.DeserializeObject<Objeto>(responseBody);

                            try
                            {
                                esPrueba= Convert.ToBoolean(Convert.ToInt32(result.Es_prueba));
                                activo = Convert.ToBoolean(Convert.ToInt32(result.Activo));
                                fecha = Convert.ToDateTime(result.Fecha);
                                Console.WriteLine(result);
                                
                            }
                            catch (Exception e)
                            {

                                return ;
                            }
                           

                        }
                    }
                }
            }
            
            catch (WebException ex)
            {
                // Handle error
            }
            return ;
        }


        private string ObtenerIDdisco()
        {
            string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
            disk.Get();
            

            return disk["VolumeSerialNumber"].ToString();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            ObtenerAPI(textBox1.Text);

            if (esPrueba)
            {
                if (DateTime.Today < fecha)
                {
                    MessageBox.Show("Version de prueba");
                    Program.esVersionDePrueba = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("la version caducó.");
                    Application.Exit();
                }
                return;
            }

            if (!activo)
            {
                comercio.RegistrarLicencia(Seguridad.Encriptar(ObtenerIDdisco()));
                MessageBox.Show("Registrado Correctamente! " +
                    "Inicie nuevamente el sistema");
                Application.Exit(); return;
            }
            else
            {
                MessageBox.Show("error al registrar. La licencia no existe o ya ha sido activada. Comuníquese con el Desarrollador");
                Application.Exit();
            }

                     

        }
        

        private void registrar_Load(object sender, EventArgs e)
        {
            if (Seguridad.Encriptar(ObtenerIDdisco()) == comercio.licencia)
            {
                MessageBox.Show("Licencia OK");
                form_login f = new form_login();
                f.ShowDialog();
                this.Dispose();
               
               
            }
        }
    }
}
