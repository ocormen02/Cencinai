using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Cencinai.Web.Enum;
using Cencinai.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Cencinai.Web.Controllers
{
    public class ResponsableController : BaseController
    {
        #region Constructor
        public readonly IResponsableRepo responsableRepo;
        public readonly IProvinciaRepo provinciaRepo;
        public readonly ICantonRepo cantonRepo;
        public readonly IDistritoRepo distritoRepo;

        public ResponsableController(
            IResponsableRepo _responsableRepo,
            IProvinciaRepo _provinciaRepo,
            ICantonRepo _cantonRepo,
            IDistritoRepo _distritoRepo
            )
        {
            responsableRepo = _responsableRepo;
            provinciaRepo = _provinciaRepo;
            cantonRepo = _cantonRepo;
            distritoRepo = _distritoRepo;
        }
        #endregion

        public IActionResult ListarResponsables(int pagina = 1, string filtro = null)
        {
            try
            {
                ViewData["filtro"] = filtro;
                var responsables = responsableRepo.ObtenerResponsables(pagina, filtro);

                return View(responsables.Result);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult AgregarResponsable()
        {
            try
            {
                var provincias = provinciaRepo.ObtenerProvincias().Result;
                var cantones = cantonRepo.ObtenerCantones().Result;
                var distritos = distritoRepo.ObtenerDistritos().Result;

                ViewBag.provincias = SelectListHelper.ObtenerListaProvincia(provincias);
                ViewBag.cantones = SelectListHelper.ObtenerListaCanton(cantones);
                ViewBag.distritos = SelectListHelper.ObtenerListaDistrito(distritos);

                return View();
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
            
        }

        [HttpPost]
        public IActionResult AgregarResponsable(ResponsableModel responsable)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    responsableRepo.AgregarResponsable(responsable);

                    Alert("El responsable ha sido registrado", NotificationType.success);

                    return RedirectToAction("ListarResponsables");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult DetalleResponsable(int id)
        {
            try
            {
                var responsable = responsableRepo.ObtenerResponsablePorId(id).Result;

                return View(responsable);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public IActionResult EditarResponsable(int id)
        {
            try
            {
                var responsable = responsableRepo.ObtenerResponsablePorId(id).Result;

                return View(responsable);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditarResponsable(ResponsableModel responsable)
        {
            try
            {
                responsableRepo.EditarResponsable(responsable);

                Alert("El responsable ha sido modificado", NotificationType.success);

                return RedirectToAction("ListarResponsables");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }

    }
}