﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebCoreMVC.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dosagem { get; set; }
        public string UnidadeDosagem { get; set; }

    }
}