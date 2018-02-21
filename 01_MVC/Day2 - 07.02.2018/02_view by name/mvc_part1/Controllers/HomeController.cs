using System.Web.Mvc;

namespace mvc_part1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index(int id)
        {
            switch (id)
            {
                //protected internal ViewResult View(string viewName)
                case 0: return View("ZeroIndex");
               default:
                    {
                        if (id > 0)
                        {
                            //protected internal ViewResult View(string viewName, object model);
                            return View("PosIndex", "Pos Index");
                        }

                        //return View("Index");
                        return View();  
                    }
                          
        }
     
        }



    }
}
