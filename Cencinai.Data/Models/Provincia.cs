using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Canton = new HashSet<Canton>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [InverseProperty("Provincia")]
        public virtual ICollection<Canton> Canton { get; set; }
    }
}
