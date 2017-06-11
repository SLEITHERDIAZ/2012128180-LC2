using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class TipoLinea
    {

        public int TipoLineaId { get; set; }

      
        public ICollection<LineaTelefonica> LineaTelefonica { get; set; }
        public int LineaTelefonicaId { get; set; }

        public TipoLinea()
        {
            LineaTelefonica = new Collection<LineaTelefonica>();
        }
    }
}
