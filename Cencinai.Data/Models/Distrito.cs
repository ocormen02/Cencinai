using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Responsable = new HashSet<Responsable>();
        }

        public int Id { get; set; }
        public int CantonId { get; set; }
        public string Nombre { get; set; }

        public virtual Canton Canton { get; set; }
        public virtual ICollection<Responsable> Responsable { get; set; }
    }
}
