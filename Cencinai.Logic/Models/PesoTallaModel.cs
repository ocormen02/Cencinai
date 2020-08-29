using Cencinai.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class PesoTallaModel : BaseModel
    {
        [Display(Name = "Niño Id")]
        public int NiñoId { get; set; }

        [Display(Name = "Obesidad")]
        public bool? Obesidad { get; set; }

        [Display(Name = "Sobrepeso")]
        public bool? SobrePeso { get; set; }

        [Display(Name = "Normal")]
        public bool? Normal { get; set; }

        [Display(Name = "Desnutrición")]
        public bool? Desnutricion { get; set; }

        [Display(Name = "Desnutrición Severa")]
        public bool? DesnutricionSevera { get; set; }
    }
}
