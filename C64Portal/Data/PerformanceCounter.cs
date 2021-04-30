using System;

namespace C64Portal.Data
{
    public class PerformanceCounter
    {
        public Guid ShopRepositoryID { get; set; }
        public Guid GameRepositoryID { get; set; }
        public Guid PartRepositoryID { get; set; }
        private readonly IGameRepository _gameRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IPartRepository _partRepository;
        public PerformanceCounter(IGameRepository gameRepository, IShopRepository shopRepository, IPartRepository partRepository)
        {
            _gameRepository = gameRepository;
            _shopRepository = shopRepository;
            _partRepository = partRepository;
            GameRepositoryID = _gameRepository.InstanceID;
            ShopRepositoryID = _shopRepository.InstanceID;
            PartRepositoryID = _partRepository.InstanceID;
        }
        public void CalculateMemoryUsage()
        {
            //Do Something
        }
    }
}
