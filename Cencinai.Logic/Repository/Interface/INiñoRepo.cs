using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface INiñoRepo
    {
        Task<NiñoModel> ObtenerNiñoPorId(int id);

        public int ObtenerEdadNiñoPorId(int id);

        Task<PagedResult<NiñoModel>> ObtenerNiños(int pagina, string filtro);

        void AgregarNiño(NiñoModel niño);

        void BorrarNiño(NiñoModel niño);

        void EditarNiño(NiñoModel niño);
    }
}
