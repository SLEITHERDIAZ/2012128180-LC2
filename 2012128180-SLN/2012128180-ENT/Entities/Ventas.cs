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

        public Cliente Clientes { get; set; }

        public TipoPago TipoPago { get; set; }

        public Contrato Contrato { get; set; }

        public Evaluacion Evaluacion { get; set; }

        public LineaTelefonica LineaTelefonica { get; set; }

        public CentroAtencion CentroAtencion { get; set; }
        public int CentroAtencionId { get; set; }

        public Ventas()
        {
 
        }
    }
}
