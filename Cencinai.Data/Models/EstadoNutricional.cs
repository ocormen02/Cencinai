using System;
using System.Collections.Generic;
using System.Text;

namespace Cencinai.Data.Models
{
    public partial class EstadoNutricional
    {
        public int Id { get; set; }

        public int NiñoId { get; set; }

        public string IndiceMasaCorporal { get; set; }

        public string TallaEdad { get; set; }

        public string PesoEdad { get; set; }

        public string PesoTalla { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public virtual Niño Niño { get; set; }
    }
}
