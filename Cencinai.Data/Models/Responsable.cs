using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Responsable
    {
        public Responsable()
        {
            Niño = new HashSet<Niño>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }

        [StringLength(50)]
        public string SegundoApellido { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(10)]
        public string TelefonoAdicional { get; set; }

        public int DistritoId { get; set; }

        [Required]
        [StringLength(200)]
        public string DireccionExacta { get; set; }

        [ForeignKey(nameof(DistritoId))]
        [InverseProperty("Responsable")]
        public virtual Distrito Distrito { get; set; }

        [InverseProperty("Responsable")]
        public virtual ICollection<Niño> Niño { get; set; }
    }
}
