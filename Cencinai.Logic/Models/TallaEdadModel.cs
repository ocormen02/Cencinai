using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class TallaEdadModel : BaseModel
    {
        public int NiñoId { get; set; }

        [Display(Name = "Muy Alto")]
        public bool? MuyAlto { get; set; }

        [Display(Name = "Alto")]
        public bool? Alto { get; set; }

        [Display(Name = "Normal")]
        public bool? Normal { get; set; }

        [Display(Name = "Bajo Talla")]
        public bool? BajoTalla { get; set; }

        [Display(Name = "Baja Talla Severa")]
        public bool? BajaTallaSevera { get; set; }
    }
}
