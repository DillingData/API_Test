using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;
using System.Net.Http;
using System.Text.Json;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        Place? coord = new Place();
        public IActionResult Index()
        {
            
            Root? root = new Root();

            //string lat = "55.87";
            //string longt = "12.83";

            string lat = coord.Lat;
            string longt = coord.Lon;

            string apiKey = "bef904c9d4916fca8184a376a9534a49";

            var requestURI = string.Format("https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey);
            var request = WebRequest.Create(requestURI);
            var response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readstream = new StreamReader(stream, encode);
            string s = readstream.ReadToEnd();

            root = JsonConvert.DeserializeObject<Root>(s);
            

            return View(root);
        }

        public void StoreCoord(string lat, string longt)
        {
            coord.Lat = lat;
            coord.Lon = longt;
        }

        /*
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        
        [HttpGet]
        public async Task<ActionResult> OnGet(string lat, string longt)
        {
            string apiKey = "bef904c9d4916fca8184a376a9534a49";

            Root? root = new Root();

            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, "https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                root = await System.Text.Json.JsonSerializer.DeserializeAsync
                <Root>(contentStream);

                return View(root);
            }
            return null;
        
        }*/
    }
}
