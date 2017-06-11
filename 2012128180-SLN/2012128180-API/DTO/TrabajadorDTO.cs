using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class TrabajadorDTO
    {
        public int TrabajadorId { get; set; }

        //public string Nombre { get; set; }
        //public string ApellIdo { get; set; }
        //public int TrabajadorCodigo { get; set; }

        public TipoTrabajador TipoTrabajador { get; set; }


        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }
    }
}