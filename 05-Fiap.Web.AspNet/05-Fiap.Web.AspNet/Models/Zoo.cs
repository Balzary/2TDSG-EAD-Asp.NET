﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Zoo
    {
        public int Jaulas { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataAbertura { get; set; }
        public string Nome { get; set; }        
        public Tipo EntidadeAdministradora { get; set; }

    }
}
