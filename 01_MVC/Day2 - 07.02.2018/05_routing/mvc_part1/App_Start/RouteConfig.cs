using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_part1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
               name: "Dima",
               url: "GetBook/{price}/{name}",
               defaults: new { controller = "Books", action = "GetBook", price =30, name ="c#"}
           );


            routes.MapRoute(
                name: "Seffy",
                url: "BestBook",
                defaults: new { controller = "Books", action = "Index"}
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = 6 }
            );
        }
    }
}
