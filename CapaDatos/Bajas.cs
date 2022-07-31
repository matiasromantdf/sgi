using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Bajas
    {
        public string codigoDeArticulo { get; set; }
        public string detalle { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public int id { get; }


        public string Registrar()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "insert into bajas" +
                    "(cod_articulo,detalle,cantidad,fecha_baja) " +
                    " values(@cod,@detalle,@cant,@fecha)";
            comando.Parameters.Add("@cod", SqlDbType.VarChar);
            comando.Parameters.Add("@detalle", SqlDbType.VarChar);
            comando.Parameters.Add("@cant", SqlDbType.Int);
            comando.Parameters.Add("@fecha", SqlDbType.Date);


            comando.Parameters["@cod"].Value = codigoDeArticulo;
            comando.Parameters["@detalle"].Value = detalle;
            comando.Parameters["@cant"].Value = cantidad;
            comando.Parameters["@fecha"].Value = fecha;

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

    //    //public Bajas Listar(int id_baja)
    //    //{

    //    //    Conexion con = new Conexion();
    //    //    SqlCommand seleccionar = new SqlCommand("select " +
    //    //        "cod_articulo," +
    //    //        "detalle," +
    //    //        "cantidad," +
    //    //        "fecha_baja," +
    //    //        "id_baja from bajas where id_baja = @id");
    //    //    seleccionar.Parameters.AddWithValue("@cod", id_baja);
    //    //    seleccionar.Connection = con.conectar();
    //    //    SqlDataReader leer;
    //    //    leer = seleccionar.ExecuteReader();
    //    //    if (leer.HasRows)
    //    //    {
    //    //        leer.Read();
    //    //        prov.Id_proveedor = id_prov;
    //    //        prov.Cc_proveedor = (float)leer.GetDecimal(1);
    //    //        prov.Nombre_proveedor = leer.GetString(2);
    //    //        prov.Telefono_proveedor = leer.GetString(3);
    //    //        prov.Cuit_proveedor = leer.GetString(4);
    //    //    }
    //    //    return prov;


    //}
}
}
