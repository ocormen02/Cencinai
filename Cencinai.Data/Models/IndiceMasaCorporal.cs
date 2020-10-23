using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class IndiceMasaCorporal
    {
        [Key]
        public int Id { get; set; }

        public int NiñoId { get; set; }

        public bool? Obesidad { get; set; }

        public bool? SobrePeso { get; set; }

        public bool? Normal { get; set; }

        public bool? Desnutricion { get; set; }

        public bool? DesnutricionSevera { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }

        [ForeignKey(nameof(NiñoId))]
        [InverseProperty("IndiceMasaCorporal")]
        public virtual Niño Niño { get; set; }
    }
}
