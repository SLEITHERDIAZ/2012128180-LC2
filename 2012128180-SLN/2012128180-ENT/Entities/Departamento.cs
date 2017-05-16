using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_ENT
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        public String Nombre { get; set; } 

        public List<Ubigeo> Ubigeos { get; set; }

        public Departamento()
        {
            {

                Ubigeos = new List<Ubigeo>();

            }
        }

    }
}
