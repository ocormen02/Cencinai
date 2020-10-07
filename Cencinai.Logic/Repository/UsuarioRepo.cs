using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cencinai.Logic.Helper;

namespace Cencinai.Logic.Repository
{
    public class UsuarioRepo : IUsuarioRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public UsuarioRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public void AgregarUsuario(UsuarioModel usuario)
        {
            var entidadUsuario = mapper.Map<Usuario>(usuario);
            entidadUsuario.FechaCreacion = DateTime.Now;
            entidadUsuario.FechaActualizacion = DateTime.Now;
            unitOfWork.Usuario.Add(entidadUsuario);
            
            unitOfWork.Complete();
        }

        public void BorrarUsuario(UsuarioModel usuario)
        {
            var entidadUsuario = mapper.Map<Usuario>(usuario);
            unitOfWork.Usuario.Remove(entidadUsuario);

            unitOfWork.Complete();
        }

        public void EditarUsuario(UsuarioModel usuario)
        {
            var usuarioBD = ObtenerUsuarioPorId(usuario.Id).Result;

            if (usuarioBD.Contraseña != usuario.Contraseña)
            {
                var password = EncryptHelper.GetHashPassword(usuario.Contraseña);
                usuario.Contraseña = password;
            }
            usuario.FechaCreacion = usuarioBD.FechaCreacion;
            usuario.FechaActualizacion = DateTime.Now;

            var entidadUsuario = mapper.Map<Usuario>(usuario);
            unitOfWork.Usuario.Update(entidadUsuario);

            unitOfWork.Complete();
        }

        public async Task<UsuarioModel> ObtenerUsuario(string usuario, string contraseña)
        {
            var resultado = await unitOfWork.Usuario.GetOne(
                x => x.NombreUsuario == usuario && x.Contraseña == contraseña);

            return mapper.Map<UsuarioModel>(resultado);
        }

        public async Task<UsuarioModel> ObtenerUsuarioPorId(int id)
        {
            var resultado = await unitOfWork.Usuario.GetOne((x => x.Id == id));

            return mapper.Map<UsuarioModel>(resultado);
        }

        public async Task<PagedResult<UsuarioModel>> ObtenerUsuarios(int pagina, string filtro)
        {
            PagedResult<UsuarioModel> usuarios = new PagedResult<UsuarioModel>();
            if (String.IsNullOrEmpty(filtro))
            {
                var resultado = await unitOfWork.Usuario.GetAllPaged(pagina, 10, null, x => x.OrderBy(o => o.Nombre));
                
                usuarios = mapper.Map<PagedResult<UsuarioModel>>(resultado);
            }
            else
            {
                var resultado = await unitOfWork.Usuario.GetAllPaged(pagina, 10, (s => s.Nombre.Contains(filtro) ||
                s.NombreUsuario.Contains(filtro)));

                usuarios = mapper.Map<PagedResult<UsuarioModel>>(resultado);
            }

            return usuarios;
        }
    }
}
