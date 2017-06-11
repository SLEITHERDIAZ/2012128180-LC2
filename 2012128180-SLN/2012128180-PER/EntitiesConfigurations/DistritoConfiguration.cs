using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfiguration()
        {
            ToTable("Distritos");
            HasKey(c => c.DistritoId);

            HasRequired(c => c.Provincia)
                .WithMany(c => c.Distritos)
                .HasForeignKey(c => c.ProvinciaId);
        }
    }
}
