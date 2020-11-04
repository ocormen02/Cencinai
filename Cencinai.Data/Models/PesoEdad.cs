using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class PesoEdad
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public bool? PesoAlto { get; set; }
        public bool? Normal { get; set; }
        public bool? BajoPeso { get; set; }
        public bool? BajoPesoSevero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
