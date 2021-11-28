using Microsoft.AspNetCore.Mvc;

namespace ApiPlayground.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
