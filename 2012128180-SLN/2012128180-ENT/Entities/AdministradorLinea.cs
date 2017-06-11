﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities
{
    public class AdministradorLinea
    {

        public int AdministradorLineaId { get; set; }

        public string Nombre { get; set; }

        //LineaTelefonica
        public ICollection<LineaTelefonica> LineaTelefonicas { get; set; }

        public AdministradorLinea()
        {
            LineaTelefonicas = new Collection<LineaTelefonica>();
        }
    }
}
