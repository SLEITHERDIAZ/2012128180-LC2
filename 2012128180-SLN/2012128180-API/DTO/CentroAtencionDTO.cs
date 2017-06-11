using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class CentroAtencionDTO
    {
        public int CentroAtencionId { get; set; }

        //public string NombreCentro { get; set; }


        public Direccion Direccion { get; set; }
        public int DireccionId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
        public int VentasId { get; set; }
    }
}