using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class VentasViewModel
    {


        public Cliente Cliente { get; set; }

        public TipoPago TipoPago { get; set; }

        public Contrato Contrato { get; set; }

        public Evaluacion Evaluacion { get; set; }

        public LineaTelefonica LineaTelefonica { get; set; }

        public CentroAtencion CentroAtencion { get; set; }
    }
}