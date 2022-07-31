using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Articulo
    {

        public string Cod_articulo { get;  set; }

        public Proveedor Prov = new Proveedor();
        public string Descr_articulo { get;  set; }
        public float Costo_articulo { get;  set; }
        public float Precio_articulo { get;  set; }
        public float Iva { get;  set; }
        public int Stock_articulo { get;  set; }
        public int Reposicion_articulo { get;  set; }
        public int Stock_minimo { get; set; }

        public Articulo() { }
        public string Registrar()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "insert into articulos" +
                    "(cod_articulo,id_proveedor,descr_articulo,costo_articulo,precio_articulo,iva,stock_articulo,reposicion_articulo,stock_minimo)" +
                    " values(@cod,@proveedor,@descr,@costo,@precio,@iva,@stock,@reposicion,@minimo)";
            comando.Parameters.Add("@cod", SqlDbType.VarChar);
            comando.Parameters.Add("@proveedor", SqlDbType.Int);
            comando.Parameters.Add("@descr", SqlDbType.VarChar);
            comando.Parameters.Add("@costo", SqlDbType.Decimal);
            comando.Parameters.Add("@precio", SqlDbType.Decimal);
            comando.Parameters.Add("@iva", SqlDbType.Decimal);
            comando.Parameters.Add("@stock", SqlDbType.Int);
            comando.Parameters.Add("@reposicion", SqlDbType.Int);
            comando.Parameters.Add("@minimo", SqlDbType.Int);

            comando.Parameters["@cod"].Value = Cod_articulo;
            comando.Parameters["@proveedor"].Value = Prov.Id_proveedor;
            comando.Parameters["@descr"].Value = Descr_articulo;
            comando.Parameters["@costo"].Value = Costo_articulo;
            comando.Parameters["@precio"].Value = Precio_articulo;
            comando.Parameters["@iva"].Value = Iva;
            comando.Parameters["@stock"].Value = 0;
            comando.Parameters["@minimo"].Value = Stock_minimo;
            comando.Parameters["@reposicion"].Value = 0;

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
        public decimal ReporteValuado()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "select sum(precio_articulo * stock_articulo) " +
                "from articulos " +
                "where descr_articulo not like '%DISCONTINUADO%'";
            decimal resultado = 1;
            SqlDataReader leer;
            try
            {
                leer = comando.ExecuteReader();
                leer.Read();
                resultado = leer.GetDecimal(0);
                // return "correcto";
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
            return resultado;
            
        }
        public void ComprarArticulo(int cant)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set stock_articulo=stock_articulo+@cant, " +
                "reposicion_articulo = reposicion_articulo-@cant " +                
                "where cod_articulo=@id";
            comando.Parameters.Add("@cant", SqlDbType.Int);
            comando.Parameters["@cant"].Value = cant;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

               // return "correcto";
            }
            catch (Exception)
            {
              //  return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }

        }
        public void VenderArticulo(int cant)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set stock_articulo=stock_articulo-@cant, " +
                "reposicion_articulo = reposicion_articulo+@cant " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@cant", SqlDbType.Int);
            comando.Parameters["@cant"].Value = cant;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception )
            {
                //  return e.Message;
            }
            finally
            {
                con.cerrarConexion();
            }

        }
        public void ActualizarCosto(float costo)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set costo_articulo=@costo " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@costo", SqlDbType.Decimal);
            comando.Parameters["@costo"].Value = costo;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }
        public void ActualizarIva(float iva)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set iva=@iva " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@iva", SqlDbType.Decimal);
            comando.Parameters["@iva"].Value = iva;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }
        public void ActualizarPrecio(float precio)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set precio_articulo=@precio " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@precio", SqlDbType.Decimal);
            comando.Parameters["@precio"].Value = precio;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public string RegistrarBaja(int cantidad)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set stock_articulo = stock_articulo-@cantidad " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@cantidad", SqlDbType.Int);
            comando.Parameters["@cantidad"].Value = cantidad;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


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

        public void ActualizarProveedor(Proveedor proveedor)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set id_proveedor=@prov " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@prov", SqlDbType.Int);
            comando.Parameters["@prov"].Value = proveedor.Id_proveedor;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }
        public void ActualizarDescripcion(string desc)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set descr_articulo=@des " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@des", SqlDbType.VarChar);
            comando.Parameters["@des"].Value = desc;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }

        }
        public void ActualizarMinimo(int minimo)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set stock_minimo=@min " +
                "where cod_articulo=@id";
            comando.Parameters.Add("@min", SqlDbType.VarChar);
            comando.Parameters["@min"].Value = minimo;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }

        }
        public void ActualizarCodigo(string nuevoCod)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "update articulos " +
                "set cod_articulo=@nuevo" +
                "where cod_articulo=@id";
            comando.Parameters.Add("@nuevo", SqlDbType.VarChar);
            comando.Parameters["@nuevo"].Value = nuevoCod;

            comando.Parameters.Add("@id", SqlDbType.VarChar);
            comando.Parameters["@id"].Value = this.Cod_articulo;


            try
            {
                comando.ExecuteNonQuery();

                // return "correcto";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }
        public DataTable BuscarPorNombre(string texto)
        {
            DataTable tablaResultados = new DataTable();

            Conexion con = new Conexion();
            SqlCommand select = new SqlCommand("select top 5 cod_articulo,descr_articulo,precio_articulo from articulos where descr_articulo like @texto");
            select.Connection = con.conectar();
            select.Parameters.AddWithValue("@texto", texto);
            SqlDataAdapter adp = new SqlDataAdapter(select);
            adp.Fill(tablaResultados);
            return tablaResultados;
        }
        public bool ExisteArticulo(string cod)
        {
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand("select count(*) from ARTICULOS where cod_articulo = @cod");
            seleccionar.Connection = con.conectar();
            seleccionar.Parameters.AddWithValue("@cod", cod);
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();

            if (leer.HasRows)
            {
                leer.Read();
                if (leer.GetInt32(0) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
       /* public DataTable ReporteParaReposicion(Proveedor proveedor)
        {
            DataTable tabla=new DataTable();
            Conexion con = new Conexion();
            SqlCommand select = new SqlCommand(
                "select * from articulos where reposicion < 0 " +
                "order by reposicion desc");
            select.Connection = con.conectar();
            SqlDataAdapter adp = new SqlDataAdapter(select);
            adp.Fill(tabla);
            
            return tabla;
        }*/
        public Articulo ListarArticulo(string cod)
        {
           
            Conexion con = new Conexion();
            SqlCommand seleccionar = new SqlCommand("select " +
                "cod_articulo," +
                "id_proveedor," +
                "descr_articulo," +
                "costo_articulo," +
                "precio_articulo," +
                "stock_articulo," +
                "reposicion_articulo," +
                "iva from ARTICULOS where cod_articulo = @cod");
            seleccionar.Parameters.AddWithValue("@cod", cod);
            seleccionar.Connection = con.conectar();
            SqlDataReader leer;
            leer = seleccionar.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                Cod_articulo = cod;
                Prov =Prov.Listar(leer.GetInt32(1));
                Descr_articulo = leer.GetString(2);
                Costo_articulo = (float)leer.GetDecimal(3);
                Precio_articulo = (float)leer.GetDecimal(4);
                Stock_articulo = leer.GetInt32(5);
                Reposicion_articulo = leer.GetInt32(6);
                Iva = (float)leer.GetDecimal(7);
            }
            else
            {
                return null;
            }
            return this;
        }

    }
}
