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

        [Display(Name = "Información Adicional")]
        public string InformacionAdicional { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Categoría")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Responsable")]
        public int ResponsableId { get; set; }

        public virtual CategoriaModel Categoria { get; set; }

        public virtual ResponsableModel Responsable { get; set; }
    }
}
