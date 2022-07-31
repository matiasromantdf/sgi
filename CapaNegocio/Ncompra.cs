using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class Ncompra
    {
        public Compra Dcompra = new Compra();

        public List<NdetalleCompra> Detalle = new List<NdetalleCompra>();
        public Ncaja ncaja = new Ncaja();
        public int Id_compra { get; set; }
        public Nproveedor Proveedor { get; set; }
        public string Num_factura { get; set; }
        public DateTime Fecha_compra { get; set; }
        public float Bruto_compra { get; set; }
        public float Iva_compra { get; set; }

       
        public Ncompra()
        {
            Id_compra = Dcompra.Id_compra;
        }
        public void AgregarItemDetalle(Narticulo articulo, string costo, string cant,string precio)
        {
            float _costo = float.Parse(costo);
            float _precio = float.Parse(precio);

            Detalle.Add(new NdetalleCompra
                (this, 
                articulo,
                int.Parse(cant),
                _costo,
                _precio
                ));

        }
      
        public void Registrar()
        {
            Dcompra.Fecha_compra = Fecha_compra;
            Dcompra.Id_proveedor = Proveedor.Id_proveedor;
            Dcompra.Num_factura = Num_factura;
            Dcompra.Bruto_compra = Bruto_compra;
            Dcompra.Iva_compra = Iva_compra;

            Dcompra.Registrar();
        }

        
    }
}
