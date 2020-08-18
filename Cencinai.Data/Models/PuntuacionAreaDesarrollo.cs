using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class PuntuacionAreaDesarrollo : Base
    {
        public int? MotoroGruesa { get; set; }
        public int? MotoraFina { get; set; }
        public int? Lenguaje { get; set; }
        public int? Cognositiva { get; set; }
        public int? SocioAfectiva { get; set; }
        public int NiñoId { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
