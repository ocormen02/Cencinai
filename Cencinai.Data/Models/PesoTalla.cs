using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class PesoTalla
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public bool? Obesidad { get; set; } = false;
        public bool? SobrePeso { get; set; } = false;
        public bool? Normal { get; set; } = false;
        public bool? Desnutricion { get; set; } = false;
        public bool? DesnutricionSevera { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
