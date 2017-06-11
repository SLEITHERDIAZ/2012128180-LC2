using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }

        //public string Nombre { get; set; }
        //public string ApellIdo { get; set; }


        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
        public int VentasId { get; set; }

    }
}