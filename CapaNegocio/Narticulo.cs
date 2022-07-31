using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Narticulo
    {
        Articulo Darticulo = new Articulo();
       
        
        public string Cod_articulo { get; private set; }
        public Nproveedor Proveedor = new Nproveedor();
        public string Descr_articulo { get; private set; }
        public float Costo_articulo { get; private set; }
        public float Precio_articulo { get; private set; }
        public float Iva { get; private set; }
        public int Stock_articulo { get; private set; }
        public int Reposicion_articulo { get; private set; }      

        public Narticulo() { }
        public bool Existe(string cod)
        {
            return Darticulo.Existe(cod);

        }

        public string NuevoArticulo(string cod, Nproveedor prov,string descr,string costo,string precio,string iva)
        {
            return
            Darticulo.Nuevo(cod,
                prov.Id_proveedor,
                descr,
                float.Parse(costo),
                float.Parse(precio),
                float.Parse(iva),
                0,
                0);
        }

        public Narticulo Listar(string cod)
        {
            if (Existe(cod))
            {
                Articulo darticulo = new Articulo();
                darticulo = darticulo.Listar(cod);


                Narticulo narticulo = new Narticulo();
                narticulo.Cod_articulo = darticulo.Cod_articulo;
                //asignamos un objeto proveedor:
                narticulo.Proveedor = Proveedor.Listar(darticulo.IdProveedor);
                narticulo.Descr_articulo = darticulo.Descr_articulo;
                narticulo.Costo_articulo = darticulo.Costo_articulo;
                narticulo.Precio_articulo = darticulo.Precio_articulo;
                narticulo.Stock_articulo = darticulo.Stock_articulo;
                narticulo.Reposicion_articulo = darticulo.Reposicion_articulo;
                narticulo.Iva = darticulo.Iva;
                return narticulo;
            }
            else return null;

            

        }

        public DataTable BuscarPorNombre(string texto)
        {
            return Darticulo.BuscarPorNombre(texto);
        }
        public void ComprarArticulo(int idprov, float costo,float precio,int cant, string cod)
        {
            Darticulo.ComprarArticulo(cant, idprov, precio, costo, cod);
        }

    }



}
