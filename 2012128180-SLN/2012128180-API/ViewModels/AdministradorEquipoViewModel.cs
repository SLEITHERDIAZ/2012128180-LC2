﻿using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class AdministradorEquipoDTO
    {
        public int AdministradorEquipoId { get; set; }

        public ICollection<EquipoCelular> EquipoCelular { get; set; }
      
    }
}