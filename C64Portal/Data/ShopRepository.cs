using C64Portal.Models;
using C64Portal.Queue;
using System;
using System.Collections.Generic;

namespace C64Portal.Data
{
    public class ShopRepository
        : IShopRepository
    {
        public Guid InstanceID { get; set; }
        public ShopRepository() :this(Guid.NewGuid())
        {
        }
        public ShopRepository(Guid instanceID)
        {
            InstanceID = instanceID;
        }

        public void Sell(Game game, decimal offer)
        {
            // Do Something
        }
    }
}
