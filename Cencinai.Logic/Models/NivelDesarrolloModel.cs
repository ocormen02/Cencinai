using System;
using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class NivelDesarrolloModel : BaseModel
    {

        [Display(Name = "Motora Gruesa")]
        public string MotoraGruesa { get; set; }

        [Display(Name = "Motora Fina")]
        public string MotoraFina { get; set; }

        [Display(Name = "Cognoscitiva")]
        public string Cognoscitiva { get; set; }

        [Display(Name = "Lenguaje")]
        public string Lenguaje { get; set; }

        [Display(Name = "Socioafectiva")]
        public string Socioafectiva { get; set; }

        [Display(Name = "Habitos")]
        public string Habitos { get; set; }

        public int NiñoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }
    }
}
