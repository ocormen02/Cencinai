using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cencinai.Logic.Helper;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Cencinai.Web.Controllers
{
    public class LoginController : Controller
    {
        #region Constructor
        public readonly IUsuarioRepo usuarioRepo;

        public LoginController(
            IUsuarioRepo _usuarioRepo)
        {
            usuarioRepo = _usuarioRepo;
        }
        #endregion Constructor

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioModel usuario)
        {
            try
            {
                List<Claim> claims = new List<Claim>();
                ClaimsIdentity identity = null;

                if (!String.IsNullOrEmpty(usuario.NombreUsuario) && !String.IsNullOrEmpty(usuario.Contraseña))
                {
                    var password = EncryptHelper.GetHashPassword(usuario.Contraseña);

                    var usuarioAuntenticado = usuarioRepo.ObtenerUsuario(usuario.NombreUsuario, password).Result;

                    if (usuarioAuntenticado != null)
                    {
                        @ViewData["nombreUsuario"] = usuarioAuntenticado.Nombre;
                        claims.Add(new Claim(ClaimTypes.Name, usuarioAuntenticado.NombreUsuario));
                       
                        identity = new ClaimsIdentity(claims
                            , CookieAuthenticationDefaults.AuthenticationScheme);

                        var principal = new ClaimsPrincipal(identity);

                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError("Contraseña", "Credenciales incorrectos");
                return View();
            }
            catch
            {
                ModelState.AddModelError("Contraseña", "Credenciales incorrectos");
                return View();
            }
        }

        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}