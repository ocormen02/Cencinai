using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public partial class Usuario : Base
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
    }
}
