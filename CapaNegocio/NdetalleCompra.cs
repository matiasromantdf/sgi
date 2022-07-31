using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
  public class NdetalleCompra
    {

        public DetalleCompra detalle = new DetalleCompra();

        public NdetalleCompra(Ncompra compra, Narticulo articulo, int cantCompra, float costo, float precio)
        {
            Compra = compra;
            Articulo = articulo;
            CantCompra = cantCompra;
            Costo = costo;
            Precio = precio;
        }

        public Ncompra Compra { get; set; }
        public Narticulo Articulo { get; set; }
        public int CantCompra { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }

        public void Registrar()
        {
            detalle.IdCompra = Compra.Id_compra;
            detalle.CodArticulo = Articulo.Cod_articulo;
            detalle.CantCompra = CantCompra;
            detalle.Costo = Costo;
            detalle.Precio = Precio;

            detalle.Registrar();

        }



    }
}
