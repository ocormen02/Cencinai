﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class ProvinciaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Provincia")]
        public string Nombre { get; set; }
    }
}
