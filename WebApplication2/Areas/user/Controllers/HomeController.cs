using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.user.Controllers
{
    public class HomeController : Controller
    {
        // GET: user/Home
        public ActionResult Index()
        {
            /*
            return RedirectToRoute(
                new
                {
                    area = "Calc",
                    controller = "Calculator",
                    action = "Index"
                });
               */

            //return Content("Text on return", "text/plain");

            /*
            string fileName = "/Content/regulamin-antyplagiatowy-2015-z-zarządzeniem-rektora1.pdf";
            //string downloadName = "someName.pdf";
            string downloadName = null;
            string fileType = "application/pdf";
            return File(fileName,fileType,downloadName);
            */

            ViewBag.Info = "UserControl";
            return View();
        }
    }
}