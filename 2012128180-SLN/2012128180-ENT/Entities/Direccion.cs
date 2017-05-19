using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Direccion
    {
        public int DireccionId { get; set; }
        public string Nombre { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }
    }
}
