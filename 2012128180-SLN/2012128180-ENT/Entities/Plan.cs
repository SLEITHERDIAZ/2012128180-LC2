using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }

        public string Nombre { get; set; }

        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public List<TipoPlan> TipoPlanes { get; set; }

        public Plan ()
        {

                TipoPlanes  = new List<TipoPlan>();

        }
    }
}
