using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class TallaEdad
    {
        [Key]
        public int Id { get; set; }

        public int NiñoId { get; set; }

        public bool? MuyAlto { get; set; }

        public bool? Alto { get; set; }

        public bool? Normal { get; set; }

        public bool? BajoTalla { get; set; }

        public bool? BajaTallaSevera { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }

        [ForeignKey(nameof(NiñoId))]
        [InverseProperty("TallaEdad")]
        public virtual Niño Niño { get; set; }
    }
}
