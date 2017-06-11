using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
   public class AdministradorEquipo
    {

        public int AdministradorEquipoId { get; set; }

        public string Nombre { get; set; }

        public ICollection<EquipoCelular> EquipoCelular { get; set; }

        public AdministradorEquipo()
        {
            EquipoCelular = new Collection<EquipoCelular>();
        }

    }
}
