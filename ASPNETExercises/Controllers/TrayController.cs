using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using ASPNetExercises.Utils;
namespace ASPNetExercises.Controllers
{
    public class TrayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ClearTray() // clear out current tray
        {
            HttpContext.Session.Remove("tray");
            HttpContext.Session.Set<String>("message", "Tray Cleared");
            return Redirect("/Home");
        }
    }
}