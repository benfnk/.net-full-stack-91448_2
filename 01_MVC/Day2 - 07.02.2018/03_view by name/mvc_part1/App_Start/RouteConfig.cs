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
            name: "Default1",
            url: "salad",
            defaults: new { controller = "Food", action = "BuySalad", IsVeg = false, foodName="salad",calories = 30 }
        );


            routes.MapRoute(
            name: "Default2",
             url: "chips",
            defaults: new { controller = "Food", action = "BuyChips", IsAllowed = false, foodName = "chips", calories = 4000 }
         );
            routes.MapRoute(
                name: "Default3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Food", action = "BuyChips", id = UrlParameter.Optional }
            );
        }
    }
}
