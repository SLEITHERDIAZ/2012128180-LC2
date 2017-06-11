using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class TipoPagoDTO
    {
        public int TipoPagoId { get; set; }
        //public string Descripcion { get; set; }

        public ICollection<Ventas> Ventas { get; set; }
        public int VentasId { get; set; }
    }
}