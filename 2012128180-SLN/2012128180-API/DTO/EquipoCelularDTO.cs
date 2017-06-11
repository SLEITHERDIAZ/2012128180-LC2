using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.DTO
{
    public class EquipoCelularDTO
    {
        public int EquipoCelularId { get; set; }

        //public string Modelo { get; set; }

        public AdministradorEquipo AdministradorEquipo { get; set; }
        public int AdministradorEquipoId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionId { get; set; }
    }
}