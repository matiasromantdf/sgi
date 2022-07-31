using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class Ncaja
    {
        Caja dcaja = new Caja();
       public float ImporteCaja { get; private set; }
       public float ImporteCosto { get; private set; }
       public float ImporteGanancia { get; private set; }
       public float Iva { get; private set; }
        

        public string ActualizarCosto(float valor)
        {
            return dcaja.ActualizarCosto(valor);
        }
        public string ActualizarGanancia(float valor)
        {
            return dcaja.ActualizarGanancia(valor);
        }
        public string ActualizarIva(float valor)
        {
            return dcaja.ActualizarIva(valor);
        }

        public void ObtenerValores()
        {                   
            Iva = dcaja.Iva;
            ImporteCaja = dcaja.ImporteCaja;
            ImporteGanancia = dcaja.ImporteGanancia;
            ImporteCosto = dcaja.ImporteCosto;
           
        }

    }
}
