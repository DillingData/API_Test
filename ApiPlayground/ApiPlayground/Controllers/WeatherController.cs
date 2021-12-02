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

        public ActionResult GetWeather(string lat, string longt)
        {
            string latitude = lat;
            string longtitude = longt;

            string apiKey = "bef904c9d4916fca8184a376a9534a49";
            string URL = "api.openweathermap.org/data/2.5/weather?lat=" + latitude + "&lon=" + longt + "&appid=" + apiKey;



            //example URL from openweathermap API
            //api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid={API key}



            return Content("it works " + lat + " & " + longt)   ;
        }

        static async Task sendApi(string[] args)
        {
            var client = new HttpClient();
            var result = 
        }
    }
}
