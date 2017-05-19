﻿using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.EntitiesConfigurations
{
   public class TipoLineaConfiguration : EntityTypeConfiguration<TipoLinea>
    {
        public TipoLineaConfiguration()
        {
            ToTable("TipoLinea");

            HasKey(c => c.TipoLineaId);

        }
    }
}
