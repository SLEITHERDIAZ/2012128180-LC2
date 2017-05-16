using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_ENT
{
   public class LineaTelefonica
    {

        public int LineaTelefonicaId { get; set; }

        public string Nombre { get; set; }

        //AdministradorLinea
        public int AdministradorLineaId { get; set; }
        public AdministradorLinea AdministradorLinea { get; set; }


    }
}
