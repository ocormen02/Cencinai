using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class CategoriaModel : BaseModel
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Categoría")]
        public string Abreviatura { get; set; }
    }
}
