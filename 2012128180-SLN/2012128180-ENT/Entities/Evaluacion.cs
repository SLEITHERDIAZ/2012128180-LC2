using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Evaluacion
    {

        public int EvaluacionId { get; set; }

        public EstadoEvaluacion EstadoEvaluacion { get; set; }

        public TipoEvaluacion TipoEvaluacion { get; set; }

        public Cliente Cliente { get; set; }

        public int VentasId { get; set; }
        public Ventas Ventas { get; set; }

        public LineaTelefonica LineaTelefonica { get; set; }

        public EquipoCelular EquipoCelular { get; set; }

        public Plan Plan { get; set; }

        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }

        public int CentroAtencionId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
 
   }

}
