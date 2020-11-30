using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class PesoEdad
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public bool? PesoAlto { get; set; } = false;
        public bool? Normal { get; set; } = false;
        public bool? BajoPeso { get; set; } = false;
        public bool? BajoPesoSevero { get; set; } = false;
        public DateTime FechaCreacion { get; set; } 
        public DateTime? FechaActualizacion { get; set; } 

        public virtual Niño Niño { get; set; }
    }
}
