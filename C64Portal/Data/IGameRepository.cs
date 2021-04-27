using C64Portal.Models;
using C64Portal.Queue;
using System.Collections.Generic;

namespace C64Portal.Data
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();

        Game Create(Game game, IPublisher publisher);
    }
}
