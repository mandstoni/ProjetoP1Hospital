﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebCoreMVC.Models
{
    public class Enfermeiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int CodigoInternoEnfermeiro { get; set; }
    }
}
