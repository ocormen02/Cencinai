using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class DireccionModel : BaseModel
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Provincia")]
        public int ProvinciaId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Cantón")]
        public int CantonId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Distrito")]
        public int DistritoId { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Dirección Exacta")]
        public string DireccionExacta { get; set; }

        public virtual CantonModel Canton { get; set; }
        public virtual DistritoModel Distrito { get; set; }
        public virtual ProvinciaModel Provincia { get; set; }
    }
}
