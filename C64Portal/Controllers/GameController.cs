using C64Portal.Data;
using Microsoft.AspNetCore.Mvc;

namespace C64Portal.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            //GameRepository gameRepository = new GameRepository();
            var games = _gameRepository.GetAllGames();
            return View(games);
        }
    }
}
