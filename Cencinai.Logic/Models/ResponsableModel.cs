using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cencinai.Logic.Models
{
    public class ResponsableModel : BaseModel
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Teléfono Adicional")]
        public string TelefonoAdicional { get; set; }

        [Display(Name = "Distrito")]
        public int DistritoId { get; set; }

        [Display(Name = "Dirección Exacta")]
        public string DireccionExacta { get; set; }

        public virtual DistritoModel Distrito { get; set; }

        public virtual ICollection<NiñoModel> Niño { get; set; }

    }
}
