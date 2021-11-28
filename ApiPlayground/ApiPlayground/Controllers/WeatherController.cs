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
    }
}
