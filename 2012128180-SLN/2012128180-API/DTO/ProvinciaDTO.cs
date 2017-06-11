using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class ProvinciaDTO
    {
        public int ProvinciaId { get; set; }

        //public string Nombre { get; set; }

        public string CadenaUbigeo { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }


        public ICollection<Distrito> Distritos { get; set; }

    }
}