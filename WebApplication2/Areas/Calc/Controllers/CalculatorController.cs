using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Calc.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calc/Add
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int? a, int? b, string calc)
        {
            //int a = Convert.ToInt32(collection[0]);
            //int b = Convert.ToInt32(collection[1]);
            //string tmp = Convert.ToString(collection[2]);
            try
            {
                
                switch (calc)
                {
                    case "+":
                        ViewBag.result = a + b;
                        break;
                    case "-":
                        ViewBag.result = a - b;
                        break;
                    case "*":
                        ViewBag.result = a * b;
                        break;
                    case "/":
                        ViewBag.result = a / b;
                        break;
                    default:
                        ViewBag.result = null;
                        break;
                }
                
                /*
                if ((collection[2].ToString()).Equals("add"))
                    ViewBag.result = a + b;
                else if (collection[2].ToString().Equals("rem"))
                    ViewBag.result = a - b;
                else if (collection[2].ToString().Equals("mul"))
                    ViewBag.result = a * b;
                else if (collection[2].ToString().Equals("div"))
                    ViewBag.result = a / b;
                   */ 
            }
            catch(Exception ex)
            {
                ViewBag.result = ex.Message;
            }
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.a = Convert.ToInt32(RouteData.Values["a"]);
            ViewBag.b = Convert.ToInt32(RouteData.Values["b"]);
            ViewBag.Action = "+";
            ViewBag.Title = "Addition";
            return View("ResultView"); 
        }

        public ActionResult Rem()
        {
            ViewBag.a = Convert.ToInt32(RouteData.Values["a"]);
            ViewBag.b = Convert.ToInt32(RouteData.Values["b"]);
            ViewBag.Action = "-";
            ViewBag.Title = "Remove";
            return View("ResultView");
        }

        public ActionResult Div()
        {
            ViewBag.a = Convert.ToInt32(RouteData.Values["a"]);
            ViewBag.b = Convert.ToInt32(RouteData.Values["b"]);
            ViewBag.Action = "/";
            ViewBag.Title = "Divide";
            return View("ResultView");
        }

        public ActionResult Mult()
        {
            ViewBag.a = Convert.ToInt32(RouteData.Values["a"]);
            ViewBag.b = Convert.ToInt32(RouteData.Values["b"]);
            ViewBag.Action = "*";
            ViewBag.Title = "Multipl";
            return View("ResultView");
        }
    }
}