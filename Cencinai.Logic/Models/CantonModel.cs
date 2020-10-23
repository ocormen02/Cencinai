using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class CantonModel
    {
        [Key]
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Cantón")]
        public int Id { get; set; }

        public int ProvinciaId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Cantón")]
        public string Nombre { get; set; }

        public virtual ProvinciaModel Provincia { get; set; }

    }
}
