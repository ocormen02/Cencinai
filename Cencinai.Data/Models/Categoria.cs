using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Niño = new HashSet<Niño>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<Niño> Niño { get; set; }
    }
}
