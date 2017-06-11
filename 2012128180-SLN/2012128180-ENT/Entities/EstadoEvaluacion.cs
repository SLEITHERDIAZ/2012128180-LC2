using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class EstadoEvaluacion
    {
        public int EstadoEvaluacionId { get; set; }

        public int EvaluacionId{get;set;}
        public ICollection<Evaluacion> Evaluacion { get; set; }

        public EstadoEvaluacion()
        {
            Evaluacion = new Collection<Evaluacion>();
        }
    }
}
