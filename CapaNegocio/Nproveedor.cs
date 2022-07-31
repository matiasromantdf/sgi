using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    
   public class Nproveedor
    {
        Proveedor Dproveedor = new Proveedor();

        public int Id_proveedor { get; private set; }
        public float Cc_proveedor { get; private set; }
        public string Nombre_proveedor { get; private set; }
        public string Telefono_proveedor { get; private set; }
        public string Cuit_proveedor { get; private set; }

        public Nproveedor(int id_proveedor, float cc_proveedor, string nombre_proveedor, string telefono_proveedor, string cuit_proveedor)
        {
            Id_proveedor = id_proveedor;
            Cc_proveedor = cc_proveedor;
            Nombre_proveedor = nombre_proveedor;
            Telefono_proveedor = telefono_proveedor;
            Cuit_proveedor = cuit_proveedor;
        }
        public Nproveedor() { }
        public string ActualizarCC(string monto)
        {
            float _monto = float.Parse(monto);
            if (_monto > 0)
            {
                return
                Dproveedor.ActualizarCC(_monto);
            }
            else
                return "nada que actualizar en CC";
        }
        public string NuevoProveedor(string nombre, string tel, string cuit)
        {
            return Dproveedor.NuevoProveedor(nombre,tel,cuit);
        }

        public DataTable ObtenerTodos()
        {
            DataTable tabla = Dproveedor.ObtenerTodos();
            return tabla;
        }

        public Nproveedor Listar(int cod)
        {
            Nproveedor prov = new Nproveedor();
            Proveedor dprov = new Proveedor();

            prov.Id_proveedor = cod;
            prov.Cc_proveedor = dprov.Cc_proveedor;
            prov.Nombre_proveedor = dprov.Nombre_proveedor;
            prov.Telefono_proveedor = dprov.Telefono_proveedor;
            prov.Cuit_proveedor = dprov.Cuit_proveedor;
            return prov;
           
            
        }

    }
    

}
