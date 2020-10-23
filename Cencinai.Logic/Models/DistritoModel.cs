using System.ComponentModel.DataAnnotations;


namespace Cencinai.Logic.Models
{
    public class DistritoModel
    {
        public int Id { get; set; }

        public int CantonId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Distrito")]
        public string Nombre { get; set; }

        public virtual CantonModel Canton { get; set; }
    }
}
