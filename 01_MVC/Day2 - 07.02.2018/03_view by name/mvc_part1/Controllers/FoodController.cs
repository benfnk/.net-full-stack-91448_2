using mvc_part1.Models;
using System.Web.Mvc;

namespace mvc_part1.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult BuyChips(Chips chips)
        {
                return View("FoodInfo", chips);
        }

        // GET: Food
        public ActionResult BuySalad(Salad salad)
        {
            return View("FoodInfo", salad);
        }
    }
}