using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Cencinai.Web.Enum;
using Cencinai.Web.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace Cencinai.Web.Controllers
{
    [Authorize]
    public class NivelDesarrolloController : BaseController
    {
        #region Constructor
        public readonly INiñoRepo niñoRepo;
        public readonly INivelDesarrolloRepo nivelDesarrolloRepo;

        public NivelDesarrolloController(INiñoRepo _niñoRepo, 
            INivelDesarrolloRepo _nivelDesarrolloRepo)
        {
            niñoRepo = _niñoRepo;
            nivelDesarrolloRepo = _nivelDesarrolloRepo;
        }
        #endregion
       
        public IActionResult Index(int pagina = 1, string filtro = null)
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

        public IActionResult ProcesarNivelDesarrollo(int id)
        {
            ViewBag.Opciones = SelectListHelper.ObtenerOpcionesAreasDesarrollo();
            NivelDesarrolloModel nivelDesarrollo = new NivelDesarrolloModel();
            nivelDesarrollo.NiñoId = id;

            return View(nivelDesarrollo);
        }

        [HttpPost]
        public IActionResult ProcesarNivelDesarrollo(NivelDesarrolloModel nivelDesarrollo)
        {
            try
            {
                nivelDesarrolloRepo.AgregarNivelDesarrollo(nivelDesarrollo);
                Alert("El nivel de desarrollo ha sido procesado", NotificationType.success);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }
    }
}
