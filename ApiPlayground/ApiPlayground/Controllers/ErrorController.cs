using Microsoft.AspNetCore.Mvc;

namespace ApiPlayground.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult LocationError()
        {
            return View();
        }
        
        public IActionResult APIError()
        {
            return View();
        }

        public IActionResult JSONError()
        {
            return View();
        }

        public IActionResult WeekdayError()
        {
            return View();
        }
    }
}
