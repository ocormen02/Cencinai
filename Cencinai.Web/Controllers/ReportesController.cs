using Cencinai.Logic.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Web.Helper;
using DinkToPdf.Contracts;
using DinkToPdf;
using System.IO;

namespace Cencinai.Web.Controllers
{
    public class ReportesController : BaseController
    {
        #region Constructor
        public readonly IEstadoNutricionalRepo estadoNutricionalRepo;
        private IConverter convertidor;

        public ReportesController(
            IEstadoNutricionalRepo _estadoNutricionalRepo,
            IConverter _convertidor)
        {
            estadoNutricionalRepo = _estadoNutricionalRepo;
            convertidor = _convertidor;
        }
        #endregion

        public IActionResult EstadoNutricional()
        {
            byte[] resultado;
            try
            {
                var listaEstadoNutricional = estadoNutricionalRepo
                                                .ObtenerReporteEstadoNutricional()
                                                .Result
                                                .Distinct()
                                                .ToList();

                string html = GenerarHTML.EstadoNutricionalHtlm(listaEstadoNutricional);

                var globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10 },
                    DocumentTitle = "Reporte de Estado Nutricional"
                };

                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = html,
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
                };

                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };

                CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
                context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));

                resultado = convertidor.Convert(pdf);

                return File(resultado, "Application/pdf");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }
    } 
}
