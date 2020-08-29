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
    public class ResponsableController : BaseController
    {
        #region Constructor
        public readonly IResponsableRepo responsableRepo;

        public ResponsableController(
            IResponsableRepo _responsableRepo)
        {
            responsableRepo = _responsableRepo;
        }
        #endregion

        public IActionResult ListarResponsables()
        {
            return View();
        }

        public IActionResult AgregarResponsable()
        {
            return View();
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

    }
}