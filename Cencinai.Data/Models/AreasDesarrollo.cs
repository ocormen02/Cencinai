using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class AreasDesarrollo
    {
        public int Id { get; set; }
        public int? MotoraGruesa { get; set; }
        public int? MotoraFina { get; set; }
        public int? Cognoscitiva { get; set; }
        public int? Lenguaje { get; set; }
        public int? Socioafectiva { get; set; }
        public int? Habitos { get; set; }
        public int NiñoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
