using System.Web.Mvc;

namespace WebApplication2.Areas.Calc
{
    public class CalcAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Calc";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Calc_default",
                "Calc/{controller}/{action}/{a}/{b}",
                new { action = "Index", a = UrlParameter.Optional , b = UrlParameter.Optional }
            );
        }
    }
}