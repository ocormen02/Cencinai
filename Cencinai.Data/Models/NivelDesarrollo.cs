using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class NivelDesarrollo
    {
        public int Id { get; set; }
        public string MotoraGruesa { get; set; }
        public string MotoraFina { get; set; }
        public string Cognoscitiva { get; set; }
        public string Lenguaje { get; set; }
        public string Socioafectiva { get; set; }
        public string Habitos { get; set; }
        public int NiñoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
