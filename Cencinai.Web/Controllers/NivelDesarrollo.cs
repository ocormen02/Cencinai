using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Logic.Repository.Interface;
using Microsoft.AspNetCore.Mvc;



namespace Cencinai.Web.Controllers
{
    public class NivelDesarrollo : BaseController
    {
        #region Constructor
        public readonly INiñoRepo niñoRepo;

        public NivelDesarrollo(INiñoRepo _niñoRepo)
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
    }
}
