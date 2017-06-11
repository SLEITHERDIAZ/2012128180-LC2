using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class EquipoCelularConfiguration : EntityTypeConfiguration<EquipoCelular>
    {

        public EquipoCelularConfiguration()
        {
            ToTable("EquiposCelular");
            HasKey(c => c.EquipoCelularId);

            HasRequired(a => a.AdministradorEquipo)
               .WithMany(e => e.EquipoCelular)
               .HasForeignKey(a => a.AdministradorEquipoId);
        }
    }
}
