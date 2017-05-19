using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Ventas
    {

        public int VentasId { get; set; }
        public string Nombre { get; set; }

        public int LineaTelfonicaId { get; set; }
        public LineaTelefonica LineaTelefonica { get; set; }

        public int ContratoId { get; set; }
        public Contrato Contrato { get; set; }

        public int CentroAtencionId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }


        // lista tipo de Cliente
        public List<Cliente> TipoClientes { get; set; }
        // lista tipo de pago
        public List<TipoPago> TipoPagos { get; set; }

        public Ventas()
        {
            
                TipoClientes = new List<Cliente>();
                TipoPagos = new List<TipoPago>();
        }

        
        

  
    }
}
