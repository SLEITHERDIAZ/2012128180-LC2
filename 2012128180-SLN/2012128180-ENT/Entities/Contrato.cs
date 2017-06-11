using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities

{
    public class Contrato
    {

        public int ContratoId { get; set; }

        public Ventas Ventas { get; set; }
        public int VentasId{get;set;}
      
        public Contrato()
        {

        }


    }
}
