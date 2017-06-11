using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class ContratoDTO
    {
        public int ContratoId { get; set; }

        //public string Descripcion { get; set; }


        public Ventas Ventas { get; set; }
        public int VentasId { get; set; }
    }
}