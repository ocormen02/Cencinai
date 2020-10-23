using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(8)]
        public string Contraseña { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
    }
}
