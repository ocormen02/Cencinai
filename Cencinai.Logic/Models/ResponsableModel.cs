using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

        public int DireccionId { get; set; }

        public virtual DireccionModel Direccion { get; set; }

    }
}
