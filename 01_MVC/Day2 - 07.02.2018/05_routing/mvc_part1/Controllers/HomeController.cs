using mvc_part1.Models;
using System.Web.Mvc;

namespace mvc_part1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index(int id)
        {
            return View();
                          
        }




    }
}
