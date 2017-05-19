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
            ToTable("EquipoCelular");

            HasKey(c => c.EquipoCelularId);

        }
    }
}
