using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Canton = new HashSet<Canton>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Canton> Canton { get; set; }
    }
}
