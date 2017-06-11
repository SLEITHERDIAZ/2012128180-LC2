using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class CentroAtencion
    {

        public int CentroAtencionId { get; set; }

        public Direccion Direccion { get; set; }
        public int DireccionId { get; set; }
        

    

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public ICollection<Ventas>Ventas { get; set; }
        public int VentasId { get; set; }

        public CentroAtencion()
        {
            Evaluacion = new Collection<Evaluacion>();
            Ventas = new Collection<Ventas>();
        }
    }
}
