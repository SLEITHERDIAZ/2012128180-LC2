﻿using _2012128180_EN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012128180_API.ViewModels
{
    public class TipoPagoViewModel
    {

        public ICollection<Ventas> Ventas { get; set; }
    }
}