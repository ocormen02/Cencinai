using Cencinai.Logic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface ICategoriaRepo
    {
        Task<IEnumerable<CategoriaModel>> ListarCategorias();
    }
}
