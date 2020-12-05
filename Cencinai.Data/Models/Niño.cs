using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Niño
    {
        public Niño()
        {
            AreasDesarrollo = new HashSet<NivelDesarrollo>();
            EstadoNutricional = new HashSet<EstadoNutricional>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string InformacionAdicional { get; set; }
        public int CategoriaId { get; set; }
        public int ResponsableId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Responsable Responsable { get; set; }
        public virtual ICollection<NivelDesarrollo> AreasDesarrollo { get; set; }
        public virtual ICollection<EstadoNutricional> EstadoNutricional { get; set; }
    }
}
