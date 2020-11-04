using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Responsable
    {
        public Responsable()
        {
            Niño = new HashSet<Niño>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAdicional { get; set; }
        public int DistritoId { get; set; }
        public string DireccionExacta { get; set; }

        public virtual Distrito Distrito { get; set; }
        public virtual ICollection<Niño> Niño { get; set; }
    }
}
