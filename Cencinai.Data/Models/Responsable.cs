using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Responsable : Base
    {
        public Responsable()
        {
            ResponsableNiño = new HashSet<ResponsableNiño>();
        }

        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAdicional { get; set; }
        public int DireccionId { get; set; }

        public virtual Direccion Direccion { get; set; }
        public virtual ICollection<ResponsableNiño> ResponsableNiño { get; set; }
    }
}
