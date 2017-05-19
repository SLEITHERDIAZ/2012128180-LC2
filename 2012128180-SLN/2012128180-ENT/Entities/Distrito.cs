using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Distrito
    {
        public int DistritoId { get; set; }
        public string Nombre { get; set; }

        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }

        
        public List<Ubigeo> Ubigeos { get; set; }

        public Distrito()
        {
           Ubigeos = new List<Ubigeo>();  
        }
    }
}
