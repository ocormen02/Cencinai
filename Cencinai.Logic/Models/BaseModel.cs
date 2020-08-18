using System;

namespace Cencinai.Logic.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}