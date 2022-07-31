using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DetalleCompra
    {
        public Compra compra = new Compra();
        public Articulo articulo = new Articulo();
        public int CantCompra { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
       // public float Subtotal { get; set; }
       public DetalleCompra() { }
        public DetalleCompra(Compra compra, Articulo art, int cantCompra, float costo,float precio)
        {
            this.compra = compra;
            this.articulo = art;
            CantCompra = cantCompra;
            Costo = costo;
            Precio = precio;
           // Subtotal = subtotal;
        }
       
        public string Registrar()
        /*
         * codigo sql para grabar tabla detalle_venta               
         */
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "Insert into detalle_compra(id_compra,cod_articulo,costo,cant_compra,precio_venta) " +
                "values(@id,@art,@costo,@cant,@precio)";
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.Add("@art", SqlDbType.VarChar);
            comando.Parameters.Add("@costo", SqlDbType.Decimal);
           
            comando.Parameters.Add("@cant", SqlDbType.Int);
            comando.Parameters.Add("@precio", SqlDbType.Decimal);

            comando.Parameters["@id"].Value = this.compra.Id_compra;
            comando.Parameters["@art"].Value = this.articulo.Cod_articulo;
            comando.Parameters["@costo"].Value = this.Costo;            
            comando.Parameters["@cant"].Value = this.CantCompra;
            comando.Parameters["@precio"].Value = this.Precio;


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
