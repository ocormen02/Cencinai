using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class PesoEdadModel : BaseModel
    {

        [Display(Name = "Niño Id")]
        public int NiñoId { get; set; }

        [Display(Name = "Peso Alto")]
        public bool? PesoAlto { get; set; }

        [Display(Name = "Normal")]
        public bool? Normal { get; set; }

        [Display(Name = "Bajo Peso")]
        public bool? BajoPeso { get; set; }

        [Display(Name = "Bajo Peso Severo")]
        public bool? BajoPesoSevero { get; set; }
    }
}
