using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_ENT
{
   public class EquipoCelular
    {
        public int EquipoCelularId { get; set; }
       
        public int AdministradorEquipoId { get; set; }

        public AdministradorEquipo AdministradoEquipo { get; set; }
    }
}
