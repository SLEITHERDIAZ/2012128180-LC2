using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Distrito
    {
        public int DistritoId { get; set; }
        public string NombreDis { get; set; }

        public Provincia Provincia { get; set; }
        public int ProvinciaId { get; set; }
        
        
        public ICollection<Direccion> Direccion { get; set; }
        string CadenaUbigeo { get; set; }

        public Distrito()
        {
            Direccion = new Collection<Direccion>();
        }
    }
}
