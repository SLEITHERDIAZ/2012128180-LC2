using _2012128180_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.EntitiesConfigurations
{
   public class AdministradorLineaConfiguration : EntityTypeConfiguration<AdministradorLinea>
    {
        public AdministradorLineaConfiguration()
        {
            ToTable("AdministradorLinea");

            HasKey(c => c.AdministradorLineaId);

            //LineaTelefonica
            HasRequired(c => c.LineaTelefonicas);
                WithMany(c => c.AdministradorLinea);

        }
    }
}
