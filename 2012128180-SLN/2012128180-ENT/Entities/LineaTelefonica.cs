using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class LineaTelefonica
    {

        public int LineaTelefonicaId { get; set; }
        
        public TipoLinea TipoLinea { get; set; }

        //AdministradorLinea
        public int AdministradorLineaId { get; set; }
        public AdministradorLinea AdministradorLinea { get; set; }

        public Ventas Ventas { get; set; }
        public int VentasId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public LineaTelefonica()
        {
            Evaluacion = new Collection<Evaluacion>();
        }

    }
}
