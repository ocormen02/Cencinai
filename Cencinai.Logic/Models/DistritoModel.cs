using System.ComponentModel.DataAnnotations;


namespace Cencinai.Logic.Models
{
    public class DistritoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Distrito")]
        public string Nombre { get; set; }
    }
}
