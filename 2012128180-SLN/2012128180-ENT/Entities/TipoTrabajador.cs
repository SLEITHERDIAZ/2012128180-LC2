using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class TipoTrabajador
    {

        public int TipoTrabajadorId { get; set; }

        public string Nombre { get; set; }

        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }
    }
}
