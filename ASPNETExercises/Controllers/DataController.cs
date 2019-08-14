using System;
using System.Net.Http;
using System.Threading.Tasks;
using ASPNetExercises.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASPNetExercises.Controllers
{
    public class DataController : Controller
    {
        AppDbContext _ctx;
        IHostingEnvironment _env;
        public DataController(AppDbContext context, IHostingEnvironment env)
        {
            _ctx = context;
            _env = env;
        }
        public IActionResult LoadCsv()
        {
            StoreModel model = new StoreModel(_ctx);
            bool storesLoaded = model.LoadCSVFromFile(_env.WebRootPath);
            if (storesLoaded)
                ViewBag.LoadedMsg = "Csv Loaded Successfully";
            else
                ViewBag.LoadedMsg = "Csv NOT Loaded";
            return View("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Json()
        {
            UtilityModel util = new UtilityModel(_ctx);
            var json = await getMenuItemJsonFromWebAsync();
            try
            {
                ViewBag.LoadedMsg = (util.loadNutritionTables(json)) ? "Menu and Item tables loaded" : "problem loading tables";
            }
            catch (Exception ex)
            {
                ViewBag.LoadedMsg = ex.Message;
            }
            return View("Index");
        }
        private async Task<String> getMenuItemJsonFromWebAsync()
        {
            string url = "https://raw.githubusercontent.com/elauersen/info3067/master/mcdonalds.json";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}