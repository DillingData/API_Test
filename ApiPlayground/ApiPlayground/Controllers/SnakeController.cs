using Microsoft.AspNetCore.Mvc;

namespace ApiPlayground.Controllers
{
    public class SnakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
