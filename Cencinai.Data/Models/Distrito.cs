using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Responsable = new HashSet<Responsable>();
        }

        [Key]
        public int Id { get; set; }

        public int CantonId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [ForeignKey(nameof(CantonId))]
        [InverseProperty("Distrito")]
        public virtual Canton Canton { get; set; }

        [InverseProperty("Distrito")]
        public virtual ICollection<Responsable> Responsable { get; set; }
    }
}
