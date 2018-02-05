using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/getMul/5
        public ActionResult getMul(int id)
        {
            return View(id);  //passing number to view as model (model is object)
        }


        // GET: Home/getSum?num1=3&num2=5
        public ActionResult getSum(int num1,int num2)
        {

            ViewBag.num1 = num1;
            ViewBag.num2 = num2;

            return View(num1+num2);  //passing number to view as model
        }




    }
}
