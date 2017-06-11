using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string  NombreDepar { get; set; }

        public int ProvinciaId { get; set; }
        public ICollection<Provincia> Provincias { get; set; }

        public Departamento()
        {
            Provincias = new Collection<Provincia>();
        }

    }
}
