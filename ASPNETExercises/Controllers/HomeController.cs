using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ASPNETExercises.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("message");
            return View();
        }
    }
}
