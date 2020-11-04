using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Niño
    {
        public Niño()
        {
            AreasDesarrollo = new HashSet<AreasDesarrollo>();
            IndiceMasaCorporal = new HashSet<IndiceMasaCorporal>();
            PesoEdad = new HashSet<PesoEdad>();
            PesoTalla = new HashSet<PesoTalla>();
            PuntuacionAreaDesarrollo = new HashSet<PuntuacionAreaDesarrollo>();
            TallaEdad = new HashSet<TallaEdad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string InformacionAdicional { get; set; }
        public int CategoriaId { get; set; }
        public int ResponsableId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Responsable Responsable { get; set; }
        public virtual ICollection<AreasDesarrollo> AreasDesarrollo { get; set; }
        public virtual ICollection<IndiceMasaCorporal> IndiceMasaCorporal { get; set; }
        public virtual ICollection<PesoEdad> PesoEdad { get; set; }
        public virtual ICollection<PesoTalla> PesoTalla { get; set; }
        public virtual ICollection<PuntuacionAreaDesarrollo> PuntuacionAreaDesarrollo { get; set; }
        public virtual ICollection<TallaEdad> TallaEdad { get; set; }
    }
}
