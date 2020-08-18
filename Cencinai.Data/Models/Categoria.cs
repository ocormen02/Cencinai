using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Categoria : Base
    {
        public Categoria()
        {
            Niño = new HashSet<Niño>();
        }

        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<Niño> Niño { get; set; }
    }
}
