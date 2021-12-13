using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;
using System.Net.Http;
//using System.Text.Json;
using Newtonsoft.Json;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            string apiKey = "bef904c9d4916fca8184a376a9534a49";

            IEnumerable<Root> root = null;

            string lat = "52.12";
            string longt = "10.50"; 

            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, "https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = httpClient.Send(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = httpResponseMessage.Content.ReadAsStream();

                root = JsonSerializer.Deserialize
                <IEnumerable<Root>>(contentStream);
            }
                return View(root);
        }

        public IEnumerable<Root> WeatherModels { get; set; }

        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        [HttpGet]
        public async Task<ActionResult> OnGet(string lat, string longt)
        {
            string apiKey = "bef904c9d4916fca8184a376a9534a49";


            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, "https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                Root root = await JsonSerializer.DeserializeAsync
                <Root>(contentStream);

                return View(root);
            }
            return null;
        }
    }
}
