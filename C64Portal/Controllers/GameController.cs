using C64Portal.Data;
using C64Portal.Models;
using C64Portal.Queue;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            _gameRepository.Create(game, new RabbitPublisher());
            return RedirectToAction("Index");
        }
    }
}
