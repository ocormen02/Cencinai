using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class PesoEdad
    {
        [Key]
        public int Id { get; set; }

        public int NiñoId { get; set; }

        public bool? PesoAlto { get; set; }

        public bool? Normal { get; set; }

        public bool? BajoPeso { get; set; }

        public bool? BajoPesoSevero { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }

        [ForeignKey(nameof(NiñoId))]
        [InverseProperty("PesoEdad")]
        public virtual Niño Niño { get; set; }
    }
}
