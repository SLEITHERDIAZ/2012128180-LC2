using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class VentasConfiguration : EntityTypeConfiguration<Ventas>
    {
        public VentasConfiguration()
        {
            ToTable("Ventas");
            HasKey(c => c.VentasId);

            HasRequired(c => c.CentroAtencion)
                .WithMany(c => c.Ventas);

            HasRequired(c => c.Contrato)
                .WithRequiredPrincipal(c => c.Ventas);

            HasRequired(c => c.TipoPago)
                .WithMany(c => c.Ventas);

            HasRequired(c => c.Clientes)
                .WithMany(c => c.Ventas);

            HasRequired(c => c.Evaluacion)
                .WithRequiredPrincipal(c => c.Ventas);

            HasRequired(a => a.LineaTelefonica)
                .WithRequiredPrincipal(c => c.Ventas);
        }
    }
}
