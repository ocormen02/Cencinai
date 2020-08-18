using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Direccion = new HashSet<Direccion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
