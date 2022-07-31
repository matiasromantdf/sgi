using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Login
    {
        public string Rol { get; set; }


        public string ObtenerRol(string user, string pass)
        {
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand(
                "select rol, CONVERT(char(100), DECRYPTBYPASSPHRASE('M', clave)) from USUARIOS " +
                "where CONVERT(char(100), DECRYPTBYPASSPHRASE('M', clave)) = @pass and " +
                "usuario = @user"
                );
            seleccionar.Parameters.Add("@pass", SqlDbType.VarChar);
            seleccionar.Parameters.Add("@user", SqlDbType.VarChar);

            seleccionar.Parameters["@pass"].Value = pass;
            seleccionar.Parameters["@user"].Value = user;


            seleccionar.Connection = con.conectar();
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                return Rol=leer.GetString(0);
            }
            else
            {
                return "datos erroneos";
            }
            
        }
        public bool SinUsuarios()
        {
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand(
                "select COUNT(*) from USUARIOS"
                );
           
            seleccionar.Connection = con.conectar();
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                if (leer.GetInt32(0) > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

        }
        public string CrearUsuario(string user,string pass,string rol)
        {
            Conexion con = new Conexion();
            SqlCommand insertar = new SqlCommand(
                "insert into USUARIOS(usuario,clave,rol) " +
                "values(@user,ENCRYPTBYPASSPHRASE('M',@pass),@rol)");

            insertar.Parameters.Add("@pass", SqlDbType.VarChar);
            insertar.Parameters.Add("@user", SqlDbType.VarChar);
            insertar.Parameters.Add("@rol", SqlDbType.VarChar);

            insertar.Parameters["@pass"].Value = pass;
            insertar.Parameters["@user"].Value = user;
            insertar.Parameters["@rol"].Value = rol;
            insertar.Connection = con.conectar();
            return insertar.ExecuteNonQuery().ToString();
        }
       
        public string ActualizarClave(string user, string pass)
        {

            Conexion con = new Conexion();
            SqlCommand insertar = new SqlCommand(
                "update USUARIOS " +
                " SET clave= ENCRYPTBYPASSPHRASE('M',@pass) " +
                "where usuario = @user");

            insertar.Parameters.Add("@pass", SqlDbType.VarChar);
            insertar.Parameters.Add("@user", SqlDbType.VarChar);
           

            insertar.Parameters["@pass"].Value = pass;
            insertar.Parameters["@user"].Value = user;
            
            insertar.Connection = con.conectar();
            return insertar.ExecuteNonQuery().ToString();
        }

        public DataTable ListarUsuarios()
        {
            DataTable tablaResultados = new DataTable();

            Conexion con = new Conexion();
            SqlCommand select = new SqlCommand("select usuario from usuarios");
            select.Connection = con.conectar();
            SqlDataAdapter adp = new SqlDataAdapter(select);
            adp.Fill(tablaResultados);
            return tablaResultados;
        }
    }
    

}
