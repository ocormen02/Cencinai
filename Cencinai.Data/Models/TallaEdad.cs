using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class TallaEdad : Base
    {
        public int NiñoId { get; set; }
        public bool? MuyAlto { get; set; }
        public bool? Alto { get; set; }
        public bool? Normal { get; set; }
        public bool? BajoTalla { get; set; }
        public bool? BajaTallaSevera { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
