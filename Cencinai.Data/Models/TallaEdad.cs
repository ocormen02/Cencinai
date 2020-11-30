using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class TallaEdad
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public bool? MuyAlto { get; set; } = false;
        public bool? Alto { get; set; } = false;
        public bool? Normal { get; set; } = false;
        public bool? BajoTalla { get; set; } = false;
        public bool? BajaTallaSevera { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
