using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class DireccionDTOcs
    {
        public int DireccionId { get; set; }

        //public string Direccion { get; set; }

        public string CadenaUbigeo { get; set; }

        public CentroAtencion CentroAtencion { get; set; }

        public int CentroAtencionId { get; set; }

        public Distrito Distrito { get; set; }
        public int DistritoId { get; set; }
    }
}