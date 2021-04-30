using C64Portal.Models;
using System;

namespace C64Portal.Data
{
    public interface IShopRepository
    {
        public Guid InstanceID { get; set; }
        void Sell(Game game,decimal offer);
    }
}
