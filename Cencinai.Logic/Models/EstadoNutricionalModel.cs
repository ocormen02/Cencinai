using System;

namespace Cencinai.Logic.Models
{
    public class EstadoNutricionalModel : BaseModel
    {
        public int NiñoId { get; set; }

        public string IndiceMasaCorporal { get; set; }

        public string TallaEdad { get; set; }

        public string PesoEdad { get; set; }

        public string PesoTalla { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public virtual NiñoModel Niño { get; set; }
    }
}
