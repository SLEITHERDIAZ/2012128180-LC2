using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class EquipoCelular
    {

        public int EquipoCelularId { get; set; }
        public string Nombre { get; set; }
        

        

        public int AdministradorEquipoId { get; set; }

        public List<AdministradorEquipo> AdministradoresEquipos { get; set; }

        public EquipoCelular()
        {
            AdministradoresEquipos = new List<AdministradorEquipo>();
        }
    }
}
