using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface INivelDesarrolloRepo
    {
        void AgregarNivelDesarrollo(NivelDesarrolloModel nivelDesarrollo);

        Task<IList<NivelDesarrolloModel>> ObtenerReporteNivelDesarrollo();
    }
}
