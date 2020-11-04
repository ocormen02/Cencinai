using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Canton
    {
        public Canton()
        {
            Distrito = new HashSet<Distrito>();
        }

        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Distrito> Distrito { get; set; }
    }
}
