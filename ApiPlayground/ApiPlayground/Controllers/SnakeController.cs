using Microsoft.AspNetCore.Mvc;
using ApiPlayground.Models;

namespace ApiPlayground.Controllers
{
    public class SnakeController : Controller
    {
        public IActionResult Index()
        {
            ShowScore();
            return View();
        }

        public void ShowScore()
        {
            SnakeGameModel snake = new SnakeGameModel();

            snake.Name = "Thomas";
            snake.Score = 255;

            ViewBag.name = snake.Name;
            ViewBag.score = snake.Score;
        }
    }
}
