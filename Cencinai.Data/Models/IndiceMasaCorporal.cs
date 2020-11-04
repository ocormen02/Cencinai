using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class IndiceMasaCorporal
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public bool? Obesidad { get; set; }
        public bool? SobrePeso { get; set; }
        public bool? Normal { get; set; }
        public bool? Desnutricion { get; set; }
        public bool? DesnutricionSevera { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
