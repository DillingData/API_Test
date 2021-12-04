﻿using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;
using System.Net.Http;
using System.Text.Json;

namespace ApiPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<WeatherModel>? WeatherModels { get; set; }

        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task OnGet(string lat, string longt)
        {
            string apiKey = "bef904c9d4916fca8184a376a9534a49";

            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, "api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + longt + "&appid=" + apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                WeatherModels = await JsonSerializer.DeserializeAsync
                <IEnumerable<WeatherModel>>(contentStream);
            }
        }

        public ActionResult GetWeather(string lat, string longt)
        {
            OnGet(lat, longt);

            return Content("it works " + lat + " & " + longt);
            }
    }
}
