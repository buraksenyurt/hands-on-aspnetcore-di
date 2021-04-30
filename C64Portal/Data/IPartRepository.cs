using System;

namespace C64Portal.Data
{
    public interface IPartRepository
    {
        public Guid InstanceID { get; set; }
        int GetStock(int gameId);
    }
}
