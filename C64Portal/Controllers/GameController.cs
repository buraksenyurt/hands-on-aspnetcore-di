using C64Portal.Data;
using C64Portal.Models;
using C64Portal.Queue;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace C64Portal.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IPartRepository _partRepository;
        private readonly PerformanceCounter _performanceCounter;
        private readonly ILogger<GameController> _logger;
        public GameController(
            IGameRepository gameRepository
            ,IShopRepository shopRepository
            ,IPartRepository partRepository
            , PerformanceCounter performanceCounter
            , ILogger<GameController> logger)
        {
            _logger = logger;
            _performanceCounter = performanceCounter;
            _gameRepository = gameRepository;
            _shopRepository = shopRepository;
            _partRepository = partRepository;
        }
        public IActionResult Index()
        {
            _logger.LogInformation($"\n[SINGLETON]\tShopRepo ID:{_shopRepository.InstanceID},In Perf Counter:{_performanceCounter.ShopRepositoryID}");
            _logger.LogInformation($"\n[TRANSIENT]\tGameRepo ID:{_gameRepository.InstanceID},In Perf Counter:{_performanceCounter.GameRepositoryID}");
            _logger.LogInformation($"\n[SCOPED   ]\tPartRepo ID:{_partRepository.InstanceID},In Perf Counter:{_performanceCounter.PartRepositoryID}");

            //GameRepository gameRepository = new GameRepository();
            var games = _gameRepository.GetAllGames();
            _performanceCounter.CalculateMemoryUsage();
            return View(games);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            _gameRepository.Publisher = new RabbitPublisher();
            _gameRepository.Create(game);
            return RedirectToAction("Index");
        }
    }
}
