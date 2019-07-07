using Microsoft.AspNetCore.Mvc;

namespace ASPNETExercises.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
