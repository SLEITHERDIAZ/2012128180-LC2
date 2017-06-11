using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class EvaluacionConfiguration : EntityTypeConfiguration<Evaluacion>
    {
        public EvaluacionConfiguration()
        {
            ToTable("Evaluaciones");
            HasKey(c => c.EvaluacionId);

            HasRequired(a => a.EquipoCelular)
               .WithMany(a => a.Evaluacion);

            HasRequired(a => a.LineaTelefonica)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.CentroAtencion)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.Plan)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.Trabajador)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.EstadoEvaluacion)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.TipoEvaluacion)
                .WithMany(a => a.Evaluacion);

            HasRequired(a => a.Cliente)
                .WithMany(a => a.Evaluacion);
        }
    }
}
