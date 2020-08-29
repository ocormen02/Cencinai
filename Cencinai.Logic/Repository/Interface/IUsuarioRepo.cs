using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface IUsuarioRepo
    {
        Task<UsuarioModel> ObtenerUsuario(string usuario, string contraseña);

        Task<UsuarioModel> ObtenerUsuarioPorId(int id);

        Task<PagedResult<UsuarioModel>> ObtenerUsuarios(int pagina, string filtro);

        void AgregarUsuario(UsuarioModel usuario);

        void BorrarUsuario(UsuarioModel usuario);

        void EditarUsuario(UsuarioModel usuario);

    }
}
