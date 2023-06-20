using Microsoft.AspNetCore.Mvc;

namespace lab15.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
