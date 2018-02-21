using System.Web.Mvc;

namespace mvc_part1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*
        protected internal ViewResult View(string viewName);
        protected internal ViewResult View(object model);
        */
        public ActionResult Index()
        {

            double d = 1.2;
            int i = 3;
            IncNum(d);
            IncNum(num2:i);


            //------------------named parameter---------------
            //sending the string with a named parameter
            //to avoid the "viewName" overrloading
            return View(model:"Hello view");
        }


        private int IncNum(int num1)
        {
            return num1++;
        }


        private double IncNum(double num2)
        {
            return num2++;
        }


    }
}
