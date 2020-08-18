using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Direccion : Base
    {
        public Direccion()
        {
            Responsable = new HashSet<Responsable>();
        }

        public int ProvinciaId { get; set; }
        public int CantonId { get; set; }
        public int DistritoId { get; set; }
        public string DireccionExacta { get; set; }

        public virtual Canton Canton { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Responsable> Responsable { get; set; }
    }
}
