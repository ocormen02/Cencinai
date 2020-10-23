using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class PuntuacionAreaDesarrollo
    {
        [Key]
        public int Id { get; set; }

        public int? MotoroGruesa { get; set; }

        public int? MotoraFina { get; set; }

        public int? Lenguaje { get; set; }

        public int? Cognositiva { get; set; }

        public int? SocioAfectiva { get; set; }

        public int NiñoId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }

        [ForeignKey(nameof(NiñoId))]
        [InverseProperty("PuntuacionAreaDesarrollo")]
        public virtual Niño Niño { get; set; }
    }
}
