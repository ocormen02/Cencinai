using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Niño
    {
        public Niño()
        {
            AreasDesarrollo = new HashSet<AreasDesarrollo>();
            IndiceMasaCorporal = new HashSet<IndiceMasaCorporal>();
            PesoEdad = new HashSet<PesoEdad>();
            PesoTalla = new HashSet<PesoTalla>();
            PuntuacionAreaDesarrollo = new HashSet<PuntuacionAreaDesarrollo>();
            TallaEdad = new HashSet<TallaEdad>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string PrimerApellido { get; set; }

        [StringLength(20)]
        public string SegundoApellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        public string InformacionAdicional { get; set; }

        public int CategoryId { get; set; }

        public int ResponsableId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categoria.Niño))]
        public virtual Categoria Category { get; set; }

        [ForeignKey(nameof(ResponsableId))]
        [InverseProperty("Niño")]
        public virtual Responsable Responsable { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<AreasDesarrollo> AreasDesarrollo { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<IndiceMasaCorporal> IndiceMasaCorporal { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<PesoEdad> PesoEdad { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<PesoTalla> PesoTalla { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<PuntuacionAreaDesarrollo> PuntuacionAreaDesarrollo { get; set; }

        [InverseProperty("Niño")]
        public virtual ICollection<TallaEdad> TallaEdad { get; set; }
    }
}
