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
        public string NombreDire { get; set; }

        string CadenaUbigeo { get; set; }

        public CentroAtencion CentroAtencion { get; set; }
        public int CentroAtencionId { get; set; }

        public Distrito Distrito { get; set; }
        public int DistritoId { get; set;}

    }   
}
