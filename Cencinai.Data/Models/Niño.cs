using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Niño : Base
    {
        public Niño()
        {
            AreasDesarrollo = new HashSet<AreasDesarrollo>();
            IndiceMasaCorporal = new HashSet<IndiceMasaCorporal>();
            PesoEdad = new HashSet<PesoEdad>();
            PesoTalla = new HashSet<PesoTalla>();
            PuntuacionAreaDesarrollo = new HashSet<PuntuacionAreaDesarrollo>();
            ResponsableNiño = new HashSet<ResponsableNiño>();
            TallaEdad = new HashSet<TallaEdad>();
        }

        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string InformacionAdicional { get; set; }
        public int CategoryId { get; set; }

        public virtual Categoria Category { get; set; }
        public virtual ICollection<AreasDesarrollo> AreasDesarrollo { get; set; }
        public virtual ICollection<IndiceMasaCorporal> IndiceMasaCorporal { get; set; }
        public virtual ICollection<PesoEdad> PesoEdad { get; set; }
        public virtual ICollection<PesoTalla> PesoTalla { get; set; }
        public virtual ICollection<PuntuacionAreaDesarrollo> PuntuacionAreaDesarrollo { get; set; }
        public virtual ICollection<ResponsableNiño> ResponsableNiño { get; set; }
        public virtual ICollection<TallaEdad> TallaEdad { get; set; }
    }
}
