using Ninject.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class TipoPlanDTO
    {
        public int TipoPlanId { get; set; }

        //public string Descripcion { get; set; }

        public ICollection<Plan> Plan { get; set; }

    }
}