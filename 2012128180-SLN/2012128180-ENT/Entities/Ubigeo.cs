using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Ubigeo
   {
        public int UbigeoId { get; set; }
        public string Nombre { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        public int DistritoId { get; set; }
        public Distrito Distrito { get; set; }

        public int ProvinciaId { get; set; }
        public Provincia Procincia { get; set; }
    }
}
