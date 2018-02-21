using mvc_part1.Models;
using System.Web.Mvc;

namespace mvc_part1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index(int id = 1)
        {

            Person p;
            switch (id)
            {
                case 1: p = new Student()
                {
                    FullName = "Bob",
                    Age = 15,
                    Grade = 100,
                    SchoolName = "Ort"
                };break;

                case 2:
                    p = new Manager()
                    {
                        FullName = "Alice",
                        Age = 15,
                        Salary = 10000
                    }; break;

                default:
                    p = new Person()
                    {
                        FullName = "Shahar",
                        Age = 15
                    }; break;
            }
   
            return View(p);
        }



    }
}
