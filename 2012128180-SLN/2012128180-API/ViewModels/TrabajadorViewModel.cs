using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class TrabajadorViewModel
    {
     

        public TipoTrabajador TipoTrabajador { get; set; }


        public ICollection<Evaluacion> Evaluacion { get; set; }
     

    }
}