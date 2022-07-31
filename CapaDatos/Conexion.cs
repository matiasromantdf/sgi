using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);

        public SqlConnection conectar()
        {
            con.Open();
            return con;
            
        }
        public void cerrarConexion()
        {
            
            con.Close();
           
        }
        
    }
    
}
