using C64Portal.Data;
using Microsoft.AspNetCore.Mvc;

namespace C64Portal.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            GameRepository gameRepository = new GameRepository();
            var games = gameRepository.GetAllGames();
            return View(games);
        }
    }
}
