using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class LineaTelefonicaDTO
    {
        public int LineaTelefonicaId { get; set; }

        //public string Descripcion { get; set; }
        public TipoLinea TipoLinea { get; set; }

        public AdministradorLinea AdministradorLinea { get; set; }
        public int AdministradorLineaId { get; set; }

        public Ventas Venta { get; set; }
        public int VentasId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }
    }
}