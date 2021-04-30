using C64Portal.Models;
using C64Portal.Queue;
using System;
using System.Collections.Generic;

namespace C64Portal.Data
{
    public class GameRepository
        : IGameRepository
    {
        public Guid InstanceID { get; set; }
        public IPublisher Publisher { get; set; }


        public GameRepository() :this(Guid.NewGuid())
        {
        }
        public GameRepository(Guid instanceID)
        {
            InstanceID = instanceID;
        }
        public IEnumerable<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game{ Id=1, Title="Commandos II",ListPrice=10.5M },
                new Game{ Id=2, Title="Prince of Persia",ListPrice=9.45M },
                new Game{ Id=3, Title="Prince of Persia",ListPrice=9.45M }
            };
        }

        public Game Create(Game game)
        {
            if (Publisher != default)
                Publisher.Send("A new game has been added to inventory");
            return game;
        }
    }
}
