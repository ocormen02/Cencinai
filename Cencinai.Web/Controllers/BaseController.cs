using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cencinai.Web.Enum;
using Microsoft.AspNetCore.Mvc;

namespace Cencinai.Web.Controllers
{
    public class BaseController : Controller
    {
        public void Alert(string message, NotificationType notificationType)
        {
            if (notificationType == NotificationType.success)
            {
                var msg = "<script type = 'text/javascript'>swal('" + "¡Éxito!" + "', '" + message + "','" + notificationType + "')" + "</script>";
                TempData["notification"] = msg;
            }
            else if (notificationType == NotificationType.error)
            {
                var msg = "<script type = 'text/javascript'>swal('" + "¡Error!" + "', '" + message + "','" + notificationType + "')" + "</script>";
                TempData["notification"] = msg;
            }

        }
    }
}