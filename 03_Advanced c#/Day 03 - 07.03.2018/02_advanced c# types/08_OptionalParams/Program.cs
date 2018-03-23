using System.Collections.Generic;

namespace OptionalParams
{
    public class Restaurant
    {        
    }

    public enum RestaurantType
    {
        Italian, 
        Sushi,
        Meat
    }

    public class GoogleMapsUtilities
    {
        // Old
        //public static List<Restaurant> GetRestaurantsAroundPoint(double x, double y, double radius, RestaurantType type)
        //{
        //    if (radius == 0)
        //    {
        //        radius = 100;
        //    }
        //    return new List<Restaurant>();
        //}

        public static List<Restaurant> GetRestaurantsAroundPoint(double x, double y, RestaurantType type = RestaurantType.Italian,
            double radius = 200)
        {
            if (radius == 0)
            {
                radius = 100;
            }
            return new List<Restaurant>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Old 
            //GoogleMapsUtilities.GetRestaurantsAroundPoint(1.0, 2.0, 0.0, RestaurantType.Italian);

            GoogleMapsUtilities.GetRestaurantsAroundPoint(1.0, 2.0, RestaurantType.Meat);
            GoogleMapsUtilities.GetRestaurantsAroundPoint(1.0, 2.0, RestaurantType.Meat, 230);
            GoogleMapsUtilities.GetRestaurantsAroundPoint(1.0, 2.0, radius: 230);




        }
    }
}
