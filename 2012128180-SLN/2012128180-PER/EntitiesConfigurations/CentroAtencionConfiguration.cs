using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfiguration()
        {
            ToTable("CentrosAtencion");
            HasKey(c => c.CentroAtencionId);

            HasRequired(c => c.Direccion)
                .WithRequiredPrincipal(c => c.CentroAtencion);


        }
    }
}
