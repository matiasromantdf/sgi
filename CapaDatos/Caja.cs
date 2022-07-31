using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Caja
    {
      public  float ImporteCaja { get; private set; }
      public float ImporteCosto { get; private set; }
      public float ImporteGanancia { get; private set; }
      public  float Iva { get; private set; }

        public Caja() {
            ObtenerValores();
        }

       public void ObtenerValores()
        {
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand("select * from caja");            
            seleccionar.Connection = con.conectar();
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                ImporteCaja = (float)leer.GetDecimal(1);
                ImporteCosto= (float)leer.GetDecimal(2);
                ImporteGanancia = (float)leer.GetDecimal(3);
                Iva = (float)leer.GetDecimal(4);
                
            }
         
        }

        public string ActualizarCosto(float monto)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update caja " +
                "set actual_costo=actual_costo+@monto";
            comando.Parameters.Add("@monto", SqlDbType.Decimal);

            comando.Parameters["@monto"].Value = monto;

            try
            {
                comando.ExecuteNonQuery();

                return "correcto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public string ActualizarGanancia(float monto)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update caja " +
                "set actual_ganancia=actual_ganancia+@monto";
            comando.Parameters.Add("@monto", SqlDbType.Decimal);

            comando.Parameters["@monto"].Value = monto;

            try
            {
                comando.ExecuteNonQuery();

                return "correcto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }
        }
        public string ActualizarIva(float monto)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update caja " +
                "set iva=iva+@monto";
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
            comando.Parameters["@monto"].Value = monto;

            try
            {
                comando.ExecuteNonQuery();

                return "correcto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }
        }

    }
}
