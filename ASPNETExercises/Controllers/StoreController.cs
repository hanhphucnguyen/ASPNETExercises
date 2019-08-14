using Microsoft.AspNetCore.Mvc;
using ASPNetExercises.Models;
using ASPNetExercises.Utils;
using Microsoft.AspNetCore.Http;
namespace ASPNetExercises.Controllers
{
    public class StoreController : Controller
    {
        AppDbContext _db;
        public StoreController(AppDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString(SessionVariables.Message) != null)
            {
                ViewBag.Message = HttpContext.Session.GetString(SessionVariables.Message);
            }
            return View();
        }
        [Route("[action]/{lat:double}/{lng:double}")]
        public IActionResult GetStores(float lat, float lng)
        {
            StoreModel model = new StoreModel(_db);
            return Ok(model.GetThreeClosestStores(lat, lng));
        }
    }
}