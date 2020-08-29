using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class PuntuacionAreaDesarrolloModel : BaseModel
    {
        [Display(Name = "Motoro Gruesa")]
        public int? MotoroGruesa { get; set; }

        [Display(Name = "Motora Fina")]
        public int? MotoraFina { get; set; }

        [Display(Name = "Lenguaje")]
        public int? Lenguaje { get; set; }

        [Display(Name = "Cognositiva")]
        public int? Cognositiva { get; set; }

        [Display(Name = "Socio Afectiva")]
        public int? SocioAfectiva { get; set; }

        [Display(Name = "Niño Id")]
        public int NiñoId { get; set; }
    }
}
