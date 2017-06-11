using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class TipoLineaDTO
    {
        public int TipoLineaId { get; set; }
        //public string Descripcion { get; set; }

        public ICollection<LineaTelefonica> LineaTelefonica { get; set; }
        public int LineaTelefonicaId { get; set; }
    }
}