using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Trabajador
    {

        public int TrabajadorId { get; set; }

        public string Nombre { get; set; }

        public List<TipoTrabajador> TipoTrabajadores { get; set; }

        public Trabajador()
        {

               TipoTrabajadores  = new List<TipoTrabajador>();

        }
    }
}
