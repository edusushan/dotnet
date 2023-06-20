using Microsoft.AspNetCore.Mvc;

namespace Lab16.Controllers
{
    public class StudentController : Controller
    {
        // GET: Home 
        public ActionResult Index()
        {
            return View();
        }
        public String show()
        {
            return "This is a second action method of home controller";
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public int studentID(int id)
        {
            return id;
        }

    }
}
