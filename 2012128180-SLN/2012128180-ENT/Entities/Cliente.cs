using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCli { get; set; }

        public int EvaluacionId { get; set; }
        public int VentasId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public ICollection<Ventas> Ventas { get; set; }

        public Cliente()
        {
            Evaluacion = new Collection<Evaluacion>();
            Ventas = new Collection<Ventas>();
        }
    }
}
