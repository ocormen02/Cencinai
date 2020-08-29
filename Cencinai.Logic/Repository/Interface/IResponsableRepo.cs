using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface IResponsableRepo
    {
        Task<ResponsableModel> ObtenerResponsablePorId(int id);

        Task<PagedResult<ResponsableModel>> ObtenerResponsables(int pagina, string filtro);

        void AgregarResponsable(ResponsableModel responsable);

        void BorrarResponsable(ResponsableModel responsable);

        void EditarResponsable(ResponsableModel responsable);
    }
}
