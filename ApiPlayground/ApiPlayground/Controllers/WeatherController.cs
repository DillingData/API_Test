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
            //string test = lat;
            //string test2 = longt;

            string apiKey = "bef904c9d4916fca8184a376a9534a49";
            string URL = "api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey;

            //example URL from openweathermap API
            //api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid={API key}



            return Content("it works " + lat + " & " + longt)   ;
        }
    }
}
