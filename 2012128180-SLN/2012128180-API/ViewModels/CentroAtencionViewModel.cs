using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class CentroAtencionViewModel
    {
        public int CentroAtencionId { get; set; }

        public Direccion Direccion { get; set; }     

        public ICollection<Evaluacion> Evaluacion { get; set; }
       
        public ICollection<Ventas> Ventas { get; set; }
       
    }
}