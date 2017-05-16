using _2012128180_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.EntitiesConfigurations
{
   public class DepartamentoConfiguration:EntityTypeConfiguration<Departamento>
    {
        //COnfiguracion de la Tabla
        public DepartamentoConfiguration()
        {
            ToTable("Departamento");
            HasKey(c => c.DepartamentoId);


        }
    }
}
