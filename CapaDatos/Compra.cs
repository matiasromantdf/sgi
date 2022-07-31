using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Compra
    {
        public int Id_compra {get;}
        public Proveedor proveedor = new Proveedor();
        public string Num_factura { set; get; }      
        public DateTime Fecha_compra { set; get; }
        public float Total_compra { set; get; }
        public float Iva_compra { set; get; }

        public List<DetalleCompra> Detalle = new List<DetalleCompra>();

        

        public Compra()
        {
            Id_compra = MostrarUltIdCompra() + 1;
        }
        public void EliminarItemDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
        public int MostrarUltIdCompra()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand("select top 1 id_compra from compra order by id_compra desc");
            comando.Connection = con.conectar();
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Read();
                int ultimoID = leer.GetInt32(0);
                return ultimoID;
            }
            else
            {
                return 0;
            }

        }
        public void AgregarItemDetalle(DetalleCompra det)
        {
            Detalle.Add(det);

        }
        public string Registrar()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "Insert into compra(id_proveedor,num_factura,fecha_compra,bruto_compra,iva_compra) " +
                "values(@idprov,@nfactura,@fecha,@monto,@iva)";
            
            comando.Parameters.Add("@idprov", SqlDbType.Int);
            comando.Parameters.Add("@nfactura", SqlDbType.VarChar);
            comando.Parameters.Add("@fecha", SqlDbType.Date);
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
            comando.Parameters.Add("@iva", SqlDbType.Decimal);
           

            comando.Parameters["@idprov"].Value = this.proveedor.Id_proveedor;
            comando.Parameters["@nfactura"].Value = this.Num_factura;
            comando.Parameters["@fecha"].Value = this.Fecha_compra;
            comando.Parameters["@monto"].Value = this.Total_compra;
            comando.Parameters["@iva"].Value = this.Iva_compra;
           
                       
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
        public Compra(int id_proveedor, string num_factura, DateTime fecha_compra, float monto_compra, float iva_compra)
        {
           
            proveedor=proveedor.Listar(id_proveedor);
            Num_factura = num_factura;
            Fecha_compra = fecha_compra;
            Total_compra = monto_compra;
            Iva_compra = iva_compra;
        }
    }
}
