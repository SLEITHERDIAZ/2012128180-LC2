using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{

    public class TipoPago
    {
        public int TipoPagoId { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
        public int VentasId { get; set; }

        public TipoPago()
        {
            Ventas = new Collection<Ventas>();
        }
    }

    
}
