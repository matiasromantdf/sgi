using System;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class DetalleVenta
    {
       
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        public Venta venta = new Venta();
        public Articulo articulo = new Articulo();

        public DetalleVenta() {
        }
        public DetalleVenta(int cantidad, float subtotal, Venta venta, Articulo articulo)
        {
            Cantidad = cantidad;
            Subtotal = subtotal;
           
            this.venta = venta;
           
            this.articulo = articulo;
        }
        public DataTable ListarDetalle(int numero)
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            Venta venta = new Venta();
            SqlCommand comando = new SqlCommand("Select * from detalle_venta where id_venta =@num");
            comando.Parameters.AddWithValue("@num", numero);
            comando.Connection = con.conectar();
            SqlDataReader lector = comando.ExecuteReader();
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Subtotal");


            while (lector.Read())
            {
                DataRow fila = tabla.NewRow();
                Articulo ar = new Articulo();
                fila["cantidad"] = lector.GetInt32(2);
                ar.ListarArticulo(lector.GetString(1));
                fila["descripcion"] = ar.Descr_articulo;
                fila["precio"] = Math.Round(lector.GetDecimal(4)*(decimal)((ar.Iva/100)+1),2);//se pasa el precio con el iva
                fila["subtotal"] = lector.GetDecimal(3);
                tabla.Rows.Add(fila);
                
            }

            return tabla;
        }
        public string Registrar()
        /*
         * codigo sql para grabar tabla detalle_venta               
         */
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "Insert into detalle_venta(id_venta,cod_articulo,cant_artic_venta,subtotal, precio_venta) values(@id,@art,@cant,@subtotal,@pcioVenta)";
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.Add("@art", SqlDbType.VarChar);
            comando.Parameters.Add("@cant", SqlDbType.Int);
            comando.Parameters.Add("@subtotal", SqlDbType.Decimal);
            comando.Parameters.Add("@pcioVenta", SqlDbType.Decimal);

            comando.Parameters["@id"].Value = this.venta.IdVenta;
            comando.Parameters["@art"].Value = this.articulo.Cod_articulo;
            comando.Parameters["@cant"].Value = this.Cantidad;
            comando.Parameters["@subtotal"].Value = this.Subtotal;
            comando.Parameters["@pcioVenta"].Value = this.articulo.Precio_articulo;

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
