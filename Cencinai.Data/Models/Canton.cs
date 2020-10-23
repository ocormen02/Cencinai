using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cencinai.Data.Models
{
    public partial class Canton
    {
        public Canton()
        {
            Distrito = new HashSet<Distrito>();
        }

        [Key]
        public int Id { get; set; }

        public int ProvinciaId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [ForeignKey(nameof(ProvinciaId))]
        [InverseProperty("Canton")]
        public virtual Provincia Provincia { get; set; }

        [InverseProperty("Canton")]
        public virtual ICollection<Distrito> Distrito { get; set; }
    }
}
