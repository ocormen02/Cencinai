using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Microsoft.AspNetCore.Mvc;



namespace Cencinai.Web.Controllers
{
    public class EstadoNutricional : BaseController
    {
        #region Constructor
        public readonly INiñoRepo niñoRepo;

        public EstadoNutricional(INiñoRepo _niñoRepo)
        {
            niñoRepo = _niñoRepo;
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

            
            if(edad < 5)
            {
                ENPrimeraEtapaModel primeraEtapa = new ENPrimeraEtapaModel();
                primeraEtapa.PesoEdad.NiñoId = id;
                primeraEtapa.PesoTalla.NiñoId = id;
                primeraEtapa.TallaEdad.NiñoId = id;

                return View("ENPrimeraEtapa", primeraEtapa);
            }
            else
            {
                ENSegundaEtapaModel segundaEtapa = new ENSegundaEtapaModel();
                segundaEtapa.IndiceMasaCorporal.NiñoId = id;
                segundaEtapa.TallaEdad.NiñoId = id;

                return View("ENSegundaEtapa", segundaEtapa);
            }

        }

        [HttpPost]
        public IActionResult ProcesarPrimeraEtapa(ENPrimeraEtapaModel primeraEtapa)
        {
            return View();
        }
    }
}
