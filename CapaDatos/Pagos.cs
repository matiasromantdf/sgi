using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Pagos
    {
        public int idPago { get; set; }
        public int idProveedor { get; set; }
        public DateTime fecha { get; set; }
        public string comprobante { get; set; }
        public float monto { get; set; }

        public void Registrar()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "insert into pagos(id_proveedor,fecha,comprobante_pago,monto_pago) " +
            "values " +
            "(@idproveedor,@fecha,@comprobante,@monto)";

            comando.Parameters.Add("@idproveedor", SqlDbType.Int);
            comando.Parameters.Add("@fecha", SqlDbType.Date);
            comando.Parameters.Add("@comprobante", SqlDbType.VarChar);
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
                       
            comando.Parameters["@idproveedor"].Value = this.idProveedor;
            comando.Parameters["@fecha"].Value = this.fecha;
            comando.Parameters["@comprobante"].Value = this.comprobante;
            comando.Parameters["@monto"].Value = this.monto;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }


        }
     }
}
