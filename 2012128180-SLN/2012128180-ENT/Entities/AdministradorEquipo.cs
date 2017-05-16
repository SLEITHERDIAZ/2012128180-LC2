using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_ENT
{
   public class AdministradorEquipo
    {

        public int AdministradorEquipoId { get; set; }

        public string Nombre { get; set; }

        public List<EquipoCelular > EquiposCelulares { get; set; }

        public AdministradorEquipo()
        {
           EquiposCelulares = new List<EquipoCelular>();
        }
    }
}
