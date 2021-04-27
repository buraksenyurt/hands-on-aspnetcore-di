using C64Portal.Models;
using System.Collections.Generic;

namespace C64Portal.Data
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();
    }
}
