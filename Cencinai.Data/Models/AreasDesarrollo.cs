using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class AreasDesarrollo
    {
        [Key]
        public int Id { get; set; }

        public int? MotoraGruesa { get; set; }

        public int? MotoraFina { get; set; }

        public int? Cognoscitiva { get; set; }

        public int? Lenguaje { get; set; }

        public int? Socioafectiva { get; set; }

        public int? Habitos { get; set; }

        public int NiñoId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }

        [ForeignKey(nameof(NiñoId))]
        [InverseProperty("AreasDesarrollo")]
        public virtual Niño Niño { get; set; }
    }
}
