using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;
using System.Net.Http;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        protected override async Task GetApi(string[] args, string lat, string longt)
        {
            string apiKey = "bef904c9d4916fca8184a376a9534a49";
            string URL = "api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey;

            var reguest = new HttpRequestMessage(HttpMethod.Get, URL);

            //var client = IHttpClientFactory.CreateClient();
        }

        public ActionResult GetWeather(string lat, string longt)
        {
            string latitude = lat;
            string longtitude = longt;

            string apiKey = "bef904c9d4916fca8184a376a9534a49";
            string URL = "api.openweathermap.org/data/2.5/weather?lat=" + latitude + "&lon=" + longt + "&appid=" + apiKey;



            //example URL from openweathermap API
            //api.openweathermap.org/data/2.5/weather?lat=55.87&lon=12.87&appid=bef904c9d4916fca8184a376a9534a49



            return Content("it works " + lat + " & " + longt)   ;
        }
        /*
        static async Task SendApi(string[] args)
        {
            var client = new HttpClient();
            var result = await 
        }
        */
    }
}
