using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class TipoTrabajadorDTO
    {
        public int TipoTrabajadorId { get; set; }

        //public string Descripcion { get; set; }

        public ICollection<Trabajador> Trabajador { get; set; }
        public int TrabajadorId { get; set; }
    }
}