using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");




            routes.MapRoute(
                name: "Calc",
                url: "{area}/{controller}/{action}/{a}/{b}"
            );

            routes.MapRoute(
                name: "PublicR",
                url: "Public/{controller}/{action}/{id}/{*catchAll}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "All",
               url: "{controller}/{action}/{id}/{*catchAll}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "WebApplication2.Controllers" }
           );

/*
            routes.MapRoute(
                name: "Ru", 
                url: "Ru{controller}/{action}/{id}", 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/           
        }
    }
}
