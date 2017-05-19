using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        public String Nombre { get; set; }



        public List<Provincia> Provincias { get; set; }

        public Departamento()
        {
            

                Provincias = new List<Provincia>();
                Ubigeos = new List<Ubigeo>();
            
        }


        public List<Ubigeo> Ubigeos { get; set; }

        

    }
}
