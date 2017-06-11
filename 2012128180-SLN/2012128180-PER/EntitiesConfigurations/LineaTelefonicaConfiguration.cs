using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class LineaTelefonicaConfiguration : EntityTypeConfiguration<LineaTelefonica>
    {
        public LineaTelefonicaConfiguration()
        {
            ToTable("LineasTelefonicas");
            HasKey(c => c.LineaTelefonicaId);

            HasRequired(c => c.AdministradorLinea)
                .WithMany(c => c.LineaTelefonicas)
                .HasForeignKey(c => c.AdministradorLineaId);

            HasRequired(c => c.TipoLinea)
                .WithMany(c => c.LineaTelefonica);
        }
    }
}
