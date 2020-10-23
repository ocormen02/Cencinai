using System;
using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class NiñoModel : BaseModel
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Pimer Apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Información Adicional")]
        public string InformacionAdicional { get; set; }

        public int CategoryId { get; set; }

        public int ResponsableId { get; set; }

        public virtual CategoriaModel Category { get; set; }

        public virtual ResponsableModel Responsable { get; set; }
    }
}
