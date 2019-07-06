using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ASPNetExercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetExercises.Controllers
{
    public class DataController : Controller
    {
        AppDbContext _ctx;
        public DataController(AppDbContext context)
        {
            _ctx = context;
        }
        public async Task<IActionResult> Index()
        {
            UtilityModel util = new UtilityModel(_ctx);
            var json = await getMenuItemJsonFromWebAsync();
            try
            {
                ViewBag.LoadedMsg = (util.loadNutritionTables(json)) ? "Menu and Item tablesloaded" : "problem loading tables";
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