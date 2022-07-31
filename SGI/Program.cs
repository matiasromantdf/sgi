using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    static class Program
    {
        public static string user;
        public static Boolean esVersionDePrueba = false;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            
            Thread t = new Thread(new ThreadStart(Mostrar));
            t.Start();
            LanzarApp();
        }

        public static void LanzarApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_login());
        }

        public static void Mostrar()
        {
            Application.Run(new presentacion());
        }
       

    }
}
