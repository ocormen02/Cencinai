using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class PesoTalla : Base
    {
        public int NiñoId { get; set; }
        public bool? Obesidad { get; set; }
        public bool? SobrePeso { get; set; }
        public bool? Normal { get; set; }
        public bool? Desnutricion { get; set; }
        public bool? DesnutricionSevera { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
