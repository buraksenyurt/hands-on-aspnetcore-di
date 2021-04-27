using C64Portal.Models;
using C64Portal.Queue;
using System.Collections.Generic;

namespace C64Portal.Data
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();
        IPublisher Publisher { get; set; }
        Game Create(Game game);
    }
}
