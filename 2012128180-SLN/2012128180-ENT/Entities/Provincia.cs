using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Provincia
    {

        public int ProvinciaId { get; set; }
        public string NombrePro { get; set; }

        public string CadenaUbigeo { get; set; }
        
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        public ICollection<Distrito> Distritos { get; set; }

        public Provincia()
        {
                Distritos = new Collection<Distrito>();
        }
    }
}
