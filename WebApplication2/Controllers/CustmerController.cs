using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CustmerController : Controller
    {
        // GET: Custmer
        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult List()
        {
            List<Models.Custmer> custmers = new List<Models.Custmer>();
              
            for(int i = 0; i < 5; i++)
                custmers.Add(new Models.Custmer("CustName_" + i, i * 2));

            return View(custmers);
        }
    }
}