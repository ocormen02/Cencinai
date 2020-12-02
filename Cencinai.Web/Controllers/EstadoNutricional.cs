using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Cencinai.Web.Enum;
using Microsoft.AspNetCore.Mvc;



namespace Cencinai.Web.Controllers
{
    public class EstadoNutricional : BaseController
    {
        #region Constructor
        public readonly INiñoRepo niñoRepo;
        public readonly IEstadoNutricionalRepo estadoNutricionalRepo;

        public EstadoNutricional(INiñoRepo _niñoRepo, 
            IEstadoNutricionalRepo _estadoNutricionalRepo)
        {
            niñoRepo = _niñoRepo;
            estadoNutricionalRepo = _estadoNutricionalRepo;
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

        public IActionResult ObtenerProcesoPorEdad(int id)
        {
            var edad = niñoRepo.ObtenerEdadNiñoPorId(id);
            EstadoNutricionalModel estadoNutricional = new EstadoNutricionalModel();
            estadoNutricional.NiñoId = id;

            if (edad < 5)
            {
                return View("ENPrimeraEtapa", estadoNutricional);
            }
            else
            {
                return View("ENSegundaEtapa", estadoNutricional);
            }

        }

        [HttpPost]
        public IActionResult ProcesarEstadoNutricional(EstadoNutricionalModel primeraEtapa)
        {
            try
            {
                estadoNutricionalRepo.AgregarEstadoNutricional(primeraEtapa);
                Alert("El estado nutricional ha sido procesado", NotificationType.success);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }
    }
}
