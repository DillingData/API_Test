using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetWeather(string lat, string longt)
        {
            string test = lat;
            string test2 = longt;

            return Content("it works " + test + " & " + test2);
        }
    }
}
