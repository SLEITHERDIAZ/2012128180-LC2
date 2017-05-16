using _2012128180_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.EntitiesConfigurations
{
   public class TipoPagoConfiguration : EntityTypeConfiguration<TipoPago>
    {
        public TipoPagoConfiguration()
        {
            ToTable("TipoPago");

            HasKey(c => c.TipoPagoId);

        }
    }
}
