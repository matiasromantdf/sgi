using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Venta
    {
        public int IdVenta { set; get; }
        public DateTime FechaVenta { set; get; }
        public float Costo { set; get; }
        public float Bruto { set; get; }
        public float Iva { set; get; }
        public float CostoSinIva { set; get; }
        public string Factura { set; get; }
        public string Cae { set; get; }
        public DateTime VenCae { set; get; }
        public string TipoFactura { set; get; }
        public string Cliente { set; get; }
        public string PuntoVenta { set; get; }
        public double iva_105 { set; get; }
        public double base_105 { set; get; }
        public double iva_21 { set; get; }
        public double base_21 { set; get; }
                     
        public List<DetalleVenta> detalle;

        public Caja caja;

        public DataTable ListarTickets(DateTime fecha1, DateTime fecha2, Boolean soloFiscal)
        {
            SqlCommand comando;
            Conexion con = new Conexion();
            if (soloFiscal)
            {
                comando = new SqlCommand("select " +
                   "id_venta, fecha_venta, costo_venta, monto_venta, iva_venta, factura, cae, venc_cae, cliente, iva_105, base_105, iva_21, base_21 from ventas where fecha_venta between @f1 and @f2 AND factura not like ''");
                comando.Connection = con.conectar();
            }
            else
            {
                comando = new SqlCommand("select " +
              "id_venta, fecha_venta, costo_venta, monto_venta, iva_venta, factura, cae, venc_cae, cliente, iva_105, base_105, iva_21, base_21 from ventas where fecha_venta between @f1 and @f2 ");
                comando.Connection = con.conectar();
            }
            comando.Parameters.AddWithValue("@f1", fecha1);
            comando.Parameters.AddWithValue("@f2", fecha2);
            SqlDataReader lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(lector);
            return tabla;

        }

        public Venta Listar(int numero)
        {
            Conexion con = new Conexion();
            Venta venta = new Venta();
            SqlCommand comando = new SqlCommand("Select id_venta,fecha_venta,monto_venta,CAE,factura," +
                "iva_105, base_105, iva_21,base_21,cliente from ventas where id_venta =@num");
            comando.Parameters.AddWithValue("@num", numero);
            comando.Connection = con.conectar();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                venta.IdVenta = lector.GetInt32(0);
                venta.FechaVenta = lector.GetDateTime(1);
                venta.Bruto = (float)lector.GetDecimal(2);
                venta.Cae = lector.GetString(3);
                venta.Factura = lector.GetString(4);
                venta.iva_105 = (double)lector.GetDecimal(5);
                venta.base_105 = (double)lector.GetDecimal(6);
                venta.iva_21= (double)lector.GetDecimal(7);
                venta.base_21 = (double)lector.GetDecimal(8);
                venta.Cliente = lector.GetString(9);
                Console.WriteLine("el cliente es:" + venta.Cliente);


            }

            return venta;
        }

        public Venta()
        {
            IdVenta = MostrarUltIdVenta() + 1;
            FechaVenta = DateTime.Now;
            Bruto = 0;
            Costo = 0;
            Iva = 0;
            detalle = new List<DetalleVenta>();
            caja = new Caja();
            Factura = "";
            Cae = "";
            VenCae = new DateTime();
            TipoFactura = "";
            Cliente = "";
            PuntoVenta = "";
        }
        public void ActualizarFiscal(string fact,string cae, DateTime vencae, int punto, int id)
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "UPDATE ventas set factura = @fact, pto_venta=@punto, cae=@cae, venc_cae = @vencae where id_venta=@id ";
            comando.Parameters.AddWithValue("@fact", fact);
            comando.Parameters.AddWithValue("@cae", cae);
            comando.Parameters.AddWithValue("@vencae", vencae);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@punto", punto);
            comando.ExecuteNonQuery();
            con.cerrarConexion();
        }
        public void AgregarItemAlDetalle(DetalleVenta det)
        {            
            detalle.Add(det);
            Calcular();
        }
        public void EliminarDetalleItem(int index)
        {
            detalle.RemoveAt(index);
            Calcular();
        }
        public void Calcular()
        {
            Bruto = 0;
            Costo = 0;
            Iva = 0;
            CostoSinIva = 0;
            iva_105 = 0;
            iva_21 = 0;
            base_105 = 0;
            base_21 = 0;


            foreach (DetalleVenta det in detalle)
            {
                Bruto += (det.articulo.Precio_articulo) * det.Cantidad * ((det.articulo.Iva / 100) + 1);
                Costo += (det.articulo.Costo_articulo * ((det.articulo.Iva / 100) + 1)) * det.Cantidad;
                CostoSinIva += det.Cantidad * det.articulo.Costo_articulo;                
                Iva +=  (((det.articulo.Precio_articulo) * det.Cantidad)/100) *((det.articulo.Iva));
                if (det.articulo.Iva == 21)
                {
                    base_21 += det.articulo.Precio_articulo * det.Cantidad;
                    iva_21 += (det.articulo.Precio_articulo / 100) * 21* det.Cantidad;
                }
                if (det.articulo.Iva == 10.5)
                {
                    base_105 += det.articulo.Precio_articulo * det.Cantidad;
                    iva_105 += (det.articulo.Precio_articulo / 100) * 10.5 * det.Cantidad;
                }
            }
        }


        public string Registrar()
        {
            caja.ActualizarCosto(Costo);
            caja.ActualizarGanancia(Bruto - CostoSinIva - Iva);
            caja.ActualizarIva(Iva);

            foreach (DetalleVenta item in detalle)
            {
                item.articulo.VenderArticulo(item.Cantidad);

            }

            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.conectar();
            comando.CommandText = "Insert into ventas(fecha_venta,costo_venta,monto_venta,iva_venta, factura, cae, venc_cae, tipo_fact, cliente, pto_venta, iva_105, base_105, iva_21, base_21) " +
                " values(@fecha,@costo,@monto,@iva,@factura,@cae,@venc_cae,@tipo_fact,@cliente,@pto_venta,@iva_105, @base_105, @iva_21, @base_21)";
            comando.Parameters.Add("@fecha", SqlDbType.Date);
            comando.Parameters.Add("@costo", SqlDbType.Decimal);
            comando.Parameters.Add("@monto", SqlDbType.Decimal);
            comando.Parameters.Add("@iva", SqlDbType.Decimal);
            comando.Parameters.Add("@factura", SqlDbType.VarChar);
            comando.Parameters.Add("@cae", SqlDbType.VarChar);           
            comando.Parameters.Add("@venc_cae", SqlDbType.Date);
            comando.Parameters.Add("@tipo_fact", SqlDbType.VarChar);
            comando.Parameters.Add("@cliente", SqlDbType.VarChar);
            comando.Parameters.Add("@pto_venta", SqlDbType.VarChar);
            comando.Parameters.Add("@iva_105", SqlDbType.Decimal);
            comando.Parameters.Add("@base_105", SqlDbType.Decimal);
            comando.Parameters.Add("@iva_21", SqlDbType.Decimal);
            comando.Parameters.Add("@base_21", SqlDbType.Decimal);


            comando.Parameters["@fecha"].Value = this.FechaVenta;
            comando.Parameters["@costo"].Value = (this.CostoSinIva);
            comando.Parameters["@monto"].Value = (this.Bruto);
            comando.Parameters["@iva"].Value = (this.Iva);
            comando.Parameters["@factura"].Value = (this.Factura);
            comando.Parameters["@cae"].Value = (this.Cae);
            comando.Parameters["@venc_cae"].Value = (this.VenCae);
            comando.Parameters["@tipo_fact"].Value = (this.TipoFactura);
            comando.Parameters["@cliente"].Value = (this.Cliente);
            comando.Parameters["@pto_venta"].Value = (this.PuntoVenta);
            comando.Parameters["@iva_105"].Value = (this.iva_105);
            comando.Parameters["@base_105"].Value = (this.base_105);
            comando.Parameters["@iva_21"].Value = (this.iva_21);
            comando.Parameters["@base_21"].Value = (this.base_21);

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
        public int MostrarUltIdVenta()
        {
            Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand("select top 1 id_venta from ventas order by id_venta desc");
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
    }
}
