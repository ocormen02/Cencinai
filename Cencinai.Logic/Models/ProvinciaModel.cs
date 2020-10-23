using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class ProvinciaModel
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Provincia")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Provincia")]
        public string Nombre { get; set; }
    }
}
