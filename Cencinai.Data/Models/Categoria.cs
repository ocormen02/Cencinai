using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Niño = new HashSet<Niño>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string Abreviatura { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaActualizacion { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Niño> Niño { get; set; }
    }
}
