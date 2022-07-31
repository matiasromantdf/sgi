using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gastos
    {
        public DateTime fecha { get; set; }
        public float monto { get; set; }
        public string detalle { get; set; }
        public bool esRetiro { get; set; }

        public string Registrar()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "insert into gastos(fecha_gasto, monto_gasto, detalle_gasto, es_retiro) " +
            "values " +
            "(@fecha,@monto,@detalle,@retiro)";

            comando.Parameters.Add("@fecha", SqlDbType.Date);
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
            comando.Parameters.Add("@detalle", SqlDbType.VarChar);
            comando.Parameters.Add("@retiro", SqlDbType.Bit);

            comando.Parameters["@fecha"].Value = this.fecha;
            comando.Parameters["@monto"].Value = this.monto;
            comando.Parameters["@detalle"].Value = this.detalle;
            comando.Parameters["@retiro"].Value = this.esRetiro;


            try
            {
                comando.ExecuteNonQuery();

                 return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }


        }
    }
}
