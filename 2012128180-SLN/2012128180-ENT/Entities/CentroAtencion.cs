using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class CentroAtencion
    {

        public int CentroAtencionId { get; set; }

        public string Nombre { get; set; }


        public int DireccionId { get; set; }

        public Direccion Direccion { get; set; }
    }
}
