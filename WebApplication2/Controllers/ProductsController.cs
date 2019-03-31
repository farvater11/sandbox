using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i*100));

            if (TempData.Peek("seen item") != null)
                ViewBag.SeenItem = TempData["seen item"];

          

            return View(prodList);
        }

        public ActionResult Details()
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i * 100));

            List<int> prodIdList = new List<int>();
            for (int i = 0; i < prodList.Count(); i++)
                prodIdList.Add(prodList[i].GetId());

            return View(prodIdList);
        }

        public ActionResult Item(int? id)
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i * 100));


            ViewBag.All = RouteData.Values["catchAll"];
            foreach (var item in prodList)
            {
                if (item.GetId().Equals(id))
                {
                    ViewBag.item = item;
                    ViewBag.id = item.GetId();
                    break;
                }
            }
            TempData["seen item"] = id.ToString();
            return View();
            //ViewBag.Variable = RouteData.Values["id"];
        }

        public ActionResult PostInfo(string message)
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i * 100));

            //ViewBag.Mes = Request.Form["message"];
            ViewBag.Mes = message;
            return View("List",prodList);
        }

        [HttpPost]
        public ActionResult List(int x, int y)
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i * 100));

            ViewBag.Mes = x + y;
            return View("List", prodList);
        }

        public ActionResult QueryInfo(string message)
        {
            List<Models.Product> prodList = new List<Models.Product>();

            for (int i = 0; i < 10; i++)
                prodList.Add(new Models.Product("item #" + i, i * 100));

            ViewBag.Mes = message;
            return View("List", prodList);
        }

        public ActionResult ResendId()
        {
            if (RouteData.Values["id"] == null)
                return Content("Err");
            else
                return Content(RouteData.Values["id"].ToString());
        }

        [ChildActionOnly]
        public string GetCurrentDate()
        {
            return DateTime.Now.ToShortTimeString();
        }


    }
}