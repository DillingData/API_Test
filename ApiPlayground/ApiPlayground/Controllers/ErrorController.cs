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
    }
}
