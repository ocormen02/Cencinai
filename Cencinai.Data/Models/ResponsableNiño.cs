using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class ResponsableNiño : Base
    {
        public int ResponsableId { get; set; }
        public int NiñoId { get; set; }

        public virtual Niño Niño { get; set; }
        public virtual Responsable Responsable { get; set; }

    }
}
