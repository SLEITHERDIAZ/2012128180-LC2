using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class DireccionConfiguration : EntityTypeConfiguration<Direccion>
    {
        public DireccionConfiguration()
        {
            ToTable("Direcciones");
            HasKey(c => c.DireccionId);

            HasRequired(d => d.Distrito)
              .WithMany(d => d.Direccion)
              .HasForeignKey(d => d.DistritoId);
        }
    }
}
