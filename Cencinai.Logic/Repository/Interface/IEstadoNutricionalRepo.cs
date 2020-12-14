using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface IEstadoNutricionalRepo
    {
        void AgregarEstadoNutricional(EstadoNutricionalModel estadoNutricional);

        Task<IList<EstadoNutricionalModel>> ObtenerReporteEstadoNutricional();
    }
}
