using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Cencinai.Web.Enum;
using Cencinai.Web.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cencinai.Web.Controllers
{
    [Authorize]
    public class NiñoController : BaseController
    {
        #region Constructor
        public readonly IResponsableRepo responsableRepo;
        public readonly INiñoRepo niñoRepo;
        public readonly ICategoriaRepo categoriaRepo;

        public NiñoController(
            IResponsableRepo _responsableRepo,
            INiñoRepo _niñoRepo,
            ICategoriaRepo _categoriaRepo)
        {
            responsableRepo = _responsableRepo;
            niñoRepo = _niñoRepo;
            categoriaRepo = _categoriaRepo;
        }
        #endregion

        public IActionResult ListarNiños(int pagina = 1, string filtro = null)
        {
            try
            {
                ViewData["filtro"] = filtro;
                var niños = niñoRepo.ObtenerNiños(pagina, filtro);

                return View(niños.Result);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult AgregarNiño()
        {
            try
            {
                var responsables = responsableRepo.ListarResponsables().Result;
                var categorias = categoriaRepo.ListarCategorias().Result;
                ViewBag.responsables = SelectListHelper.ObtenerListaResponsables(responsables);
                ViewBag.categorias = SelectListHelper.ObtenerListaCategorias(categorias);
                ViewBag.sexo = SelectListHelper.ObtenerOpcionesSexo();

                return View();
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }

        }

        [HttpPost]
        public IActionResult AgregarNiño(NiñoModel niño)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    niñoRepo.AgregarNiño(niño);

                    Alert("El niño ha sido registrado", NotificationType.success);

                    return RedirectToAction("ListarNiños");
                }
                else
                {
                    var responsables = responsableRepo.ListarResponsables().Result;
                    var categorias = categoriaRepo.ListarCategorias().Result;
                    ViewBag.responsables = SelectListHelper.ObtenerListaResponsables(responsables);
                    ViewBag.categorias = SelectListHelper.ObtenerListaCategorias(categorias);

                    return View();
                }
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult DetalleNiño(int id)
        {
            try
            {
                var niño = niñoRepo.ObtenerNiñoPorId(id).Result;

                return View(niño);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult EditarNiño(int id)
        {
            try
            {
                var niño = niñoRepo.ObtenerNiñoPorId(id).Result;

                var responsables = responsableRepo.ListarResponsables().Result;
                var categorias = categoriaRepo.ListarCategorias().Result;
                ViewBag.responsables = SelectListHelper.ObtenerListaResponsables(responsables);
                ViewBag.categorias = SelectListHelper.ObtenerListaCategorias(categorias);

                return View(niño);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditarNiño(NiñoModel niño)
        {
            try
            {
                niñoRepo.EditarNiño(niño);

                Alert("El niño ha sido modificado", NotificationType.success);

                return RedirectToAction("ListarNiños");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult BorrarNiño(int id)
        {
            try
            {
                var niño = niñoRepo.ObtenerNiñoPorId(id);

                return View(niño.Result);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public IActionResult BorrarNiño(NiñoModel niño)
        {
            try
            {
                niñoRepo.BorrarNiño(niño);

                Alert("El niño ha sido eliminado", NotificationType.success);

                return RedirectToAction("ListarNiños");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }
    }
}