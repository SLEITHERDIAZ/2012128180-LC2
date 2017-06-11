using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class DepartamentoDTO
    {
        public int DepartamentoId { get; set; }

        //public string Nombre { get; set; }

        public ICollection<Provincia> Provincia { get; set; }
        public int ProvinciaId { get; set; }

    }
}