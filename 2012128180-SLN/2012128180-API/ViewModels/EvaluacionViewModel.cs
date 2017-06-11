using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class EvaluacionViewModel
    {

        public EstadoEvaluacion EstadoEvaluacion { get; set; }


        public TipoEvaluacion TipoEvaluacion { get; set; }


        public Cliente Cliente { get; set; }


        public Ventas Ventas { get; set; }


        public LineaTelefonica LineaTelefonica { get; set; }

        public EquipoCelular EquipoCelular { get; set; }

        public Plan Plan { get; set; }

        public Trabajador Trabajador { get; set; }


        public CentroAtencion CentroAtencion { get; set; }
    }
}