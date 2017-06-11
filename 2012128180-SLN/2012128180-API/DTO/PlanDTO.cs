using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class PlanDTO
    {
        public int PlanId { get; set; }

        //public string Descripcion { get; set; }
        public TipoPlan TipoPlan { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }
    }
}