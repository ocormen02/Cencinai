using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Helper;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Cencinai.Web.Enum;
using Microsoft.AspNetCore.Mvc;

namespace Cencinai.Web.Controllers
{
    public class UsuarioController : BaseController
    {
        #region Constructor
        public readonly IUsuarioRepo usuarioRepo;

        public UsuarioController(
            IUsuarioRepo _usuarioRepo)
        {
            usuarioRepo = _usuarioRepo;
        }
        #endregion

        public IActionResult ListarUsuarios(int pagina = 1, string filtro = null)
        {
            try
            {
                ViewData["filtro"] = filtro;
                var usuarios = usuarioRepo.ObtenerUsuarios(pagina, filtro);

                return View(usuarios.Result);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult CrearUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearUsuario(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var password = EncryptHelper.GetHashPassword(usuario.Contraseña);
                    usuario.Contraseña = password;
                    usuarioRepo.AgregarUsuario(usuario);

                    Alert("El usuario ha sido registrado", NotificationType.success);

                    return RedirectToAction("ListarUsuarios");
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult EditarUsuario(int id)
        {
            try
            {
                var usuario = usuarioRepo.ObtenerUsuarioPorId(id).Result;

                return View(usuario);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel usuario)
        {
            try
            {
                usuarioRepo.EditarUsuario(usuario);

                Alert("El usuario ha sido modificado", NotificationType.success);

                return RedirectToAction("ListarUsuarios");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult BorrarUsuario(int id)
        {
            try
            {
                var usuario = usuarioRepo.ObtenerUsuarioPorId(id);

                return View(usuario.Result);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public IActionResult BorrarUsuario(UsuarioModel usuario)
        {
            try
            {
                var borrarUsuario = usuarioRepo.ObtenerUsuarioPorId(usuario.Id).Result;
                usuarioRepo.BorrarUsuario(borrarUsuario);

                Alert("El usuario ha sido eliminado", NotificationType.success);

                return RedirectToAction("ListarUsuarios");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

    }
}