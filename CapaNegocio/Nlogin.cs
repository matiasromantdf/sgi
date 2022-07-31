using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Nlogin
    {
        private string RolActual="";

        Login login = new Login();
        public string Validar(string user, string pass)
        {
            RolActual= login.RetornarRol(user,pass);
            return RolActual;
        }
        public string MostrarRol()
        {
            return RolActual;
        }

        public string CrearAdmin(string user, string pass)
        {
            return
            login.CrearUsuario(user, pass,"admin");
        }
        public string CrearVendedor(string user, string pass)
        {
            return
            login.CrearUsuario(user, pass, "ventas");
        }
        public bool SinUsuarios()
        {
            return login.SinUsuarios();
        }
    }
}
