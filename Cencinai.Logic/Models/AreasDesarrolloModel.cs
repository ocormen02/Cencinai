using System;
using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class AreasDesarrolloModel : BaseModel
    {

        [Display(Name = "Motora Gruesa")]
        public int? MotoraGruesa { get; set; }

        [Display(Name = "Motora Fina")]
        public int? MotoraFina { get; set; }

        [Display(Name = "Cognoscitiva")]
        public int? Cognoscitiva { get; set; }

        [Display(Name = "Lenguaje")]
        public int? Lenguaje { get; set; }

        [Display(Name = "Socioafectiva")]
        public int? Socioafectiva { get; set; }

        [Display(Name = "Habitos")]
        public int? Habitos { get; set; }

        public int NiñoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }
}
