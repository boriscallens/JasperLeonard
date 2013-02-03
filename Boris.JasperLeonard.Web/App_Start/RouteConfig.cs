using System.Web.Mvc;
using System.Web.Routing;

namespace Boris.JasperLeonard.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Slideshow",
                url: "Slideshow/{showname}",
                defaults: new {controller="Home", action = "SlideShow"}
            );
            routes.MapRoute(
                name: "Manage",
                url: "Manage/Slideshows",
                defaults: new {controller="Manage", action="SlideShow"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}