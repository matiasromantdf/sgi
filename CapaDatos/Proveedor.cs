using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Proveedor
    {
        public int Id_proveedor { set; get; }
        public float Cc_proveedor { set; get; }
        public string Nombre_proveedor { set; get; }
        public string Telefono_proveedor { set; get; }
        public string Cuit_proveedor { get; set; }

        public string Registrar(string nombre, string tel, string cuit)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "insert into proveedores " +
                "(cc_proveedor,nombre_proveedor,telefono_proveedor,cuit_proveedor) " +
                "values(0,@nombre,@tel,@cuit)";
            comando.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@cc", SqlDbType.Decimal);
            comando.Parameters.Add("@tel", SqlDbType.VarChar);
            comando.Parameters.Add("@cuit", SqlDbType.VarChar);


            comando.Parameters["@nombre"].Value = nombre;
            comando.Parameters["@cc"].Value = 0;
            comando.Parameters["@tel"].Value = tel;
            comando.Parameters["@cuit"].Value = cuit;


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

        public string ActualizarCC(float monto)//si es cargo en la cuenta debe venir en negativo, si se 
                                                // paga al proveedor viene positivo
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update proveedores set cc_proveedor=cc_proveedor+@monto where id_proveedor = @id";
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
            comando.Parameters.Add("@id", SqlDbType.Int);

            comando.Parameters["@monto"].Value = monto;
            comando.Parameters["@id"].Value = this.Id_proveedor;

            Console.WriteLine(this.Nombre_proveedor);
            try
            {
                comando.ExecuteNonQuery();

                return "correcto cuenta corriente";
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
        public string EditarProveedor(string nombre, string tel,string cuit)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update proveedores set nombre_proveedor=@nombre, telefono_proveedor = @telefono, cuit_proveedor=@cuit where id_proveedor = @id";
            comando.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@telefono", SqlDbType.VarChar);
            comando.Parameters.Add("@cuit", SqlDbType.VarChar);
            comando.Parameters.Add("@id", SqlDbType.Int);

            comando.Parameters["@nombre"].Value = nombre;
            comando.Parameters["@telefono"].Value = tel;
            comando.Parameters["@cuit"].Value = cuit;
            comando.Parameters["@id"].Value = this.Id_proveedor;



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
        public DataTable ObtenerTodos()
        {
            DataTable tablaResultados = new DataTable();

            Conexion con = new Conexion();
            SqlCommand select = new SqlCommand("select * from proveedores");
            select.Connection = con.conectar();
            SqlDataAdapter adp = new SqlDataAdapter(select);
            adp.Fill(tablaResultados);
            return tablaResultados;
        }

        public Proveedor Listar(int id_prov)
        {
            Proveedor prov = new Proveedor();
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand("select " +
                "id_proveedor," +
                "cc_proveedor," +
                "nombre_proveedor," +
                "telefono_proveedor," +
                "cuit_proveedor from proveedores where id_proveedor = @cod");
            seleccionar.Parameters.AddWithValue("@cod", id_prov);
            seleccionar.Connection = con.conectar();
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                prov.Id_proveedor = id_prov;
                prov.Cc_proveedor = (float)leer.GetDecimal(1);
                prov.Nombre_proveedor = leer.GetString(2);
                prov.Telefono_proveedor = leer.GetString(3);
                prov.Cuit_proveedor = leer.GetString(4);
            }
            return prov;
            
           
        }    
    }
}

