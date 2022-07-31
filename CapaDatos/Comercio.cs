using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Comercio
    {
        public string nombre = "";
        public string direccion = "";
        public string cuit = "";
        public string cod_factura = "";
        public int punto_venta = 0;
        public string iibb = "";
        public string telefono = "";
        public string pagina = "";
        public string licencia = "";

        public Comercio()
        {
            Conexion con = new Conexion();

            SqlCommand comando = new SqlCommand("select id,nombre,direccion,cuit,cod_factura,punto_venta,iibb,telefono,pagina,licencia from comercio");
            comando.Connection = con.conectar();

            SqlDataReader lector;

            lector = comando.ExecuteReader();

            lector.Read();

            nombre = lector.GetString(1);
            direccion = lector.GetString(2);
            cuit = lector.GetString(3);
            cod_factura = lector.GetString(4);
            punto_venta = lector.GetInt32(5);
            iibb = lector.GetString(6);
            telefono = lector.GetString(7);
            pagina = lector.GetString(8);

            if (lector.GetString(9) != null)
            {
                //licencia = Regex.Replace(lector.GetString(9), @"\s", "");
                licencia = lector.GetString(9);
            }
            else
                licencia = "0";

            con.cerrarConexion();

        }
        public void RegistrarLicencia(string lic)
        {
            
            try
            {
                Conexion con = new Conexion();
                
                SqlCommand comando = new SqlCommand("update comercio set licencia = @lic");
                comando.Connection = con.conectar();
                comando.Parameters.Add("@lic", SqlDbType.VarChar);
                comando.Parameters["@lic"].Value = lic;

                comando.ExecuteNonQuery();
                con.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string actualizarDatos (string nom, string dir, string cuit, string cod,int ptoVenta, string ib, string tel, string pag)
        {
            string respuesta = "";
            Conexion con = new Conexion();

           

            try
            {
                SqlCommand comando = new SqlCommand(
               "update comercio set nombre = @nom, " +
               "direccion = @dir, " +
               "cuit = @cuit," +
               "cod_factura = @cod_fact," +
               "punto_venta = @pto," +
               "iibb = @ib," +
               "telefono = @tel," +
               "pagina = @pag");
                comando.Connection = con.conectar();

                comando.Parameters.Add("@nom", SqlDbType.VarChar);
                comando.Parameters.Add("@dir", SqlDbType.VarChar);
                comando.Parameters.Add("@cuit", SqlDbType.VarChar);
                comando.Parameters.Add("@cod_fact", SqlDbType.VarChar);
                comando.Parameters.Add("@pto", SqlDbType.Int);
                comando.Parameters.Add("@ib", SqlDbType.VarChar);
                comando.Parameters.Add("@tel", SqlDbType.VarChar);
                comando.Parameters.Add("@pag", SqlDbType.VarChar);


                comando.Parameters["@nom"].Value = nom;
                comando.Parameters["@dir"].Value = dir;
                comando.Parameters["@cuit"].Value = cuit;
                comando.Parameters["@cod_fact"].Value = cod;
                comando.Parameters["@pto"].Value = ptoVenta;
                comando.Parameters["@ib"].Value = ib;
                comando.Parameters["@tel"].Value = tel;
                comando.Parameters["@pag"].Value = pag;
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                respuesta = e.Message;
            }

            respuesta = "Actualizado Correctamente!";

            con.cerrarConexion();
            return respuesta;
        }


    }
}
