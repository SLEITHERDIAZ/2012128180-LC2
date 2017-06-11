using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        

        public TipoPlan TipoPlan { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public Plan()
        {
            Evaluacion = new Collection<Evaluacion>();

        }

       
    }
}
