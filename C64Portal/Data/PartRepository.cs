using System;

namespace C64Portal.Data
{
    public class PartRepository
        : IPartRepository
    {
        public Guid InstanceID { get; set; }
        public PartRepository() :this(Guid.NewGuid())
        {
        }
        public PartRepository(Guid instanceID)
        {
            InstanceID = instanceID;
        }

        public int GetStock(int gameId)
        {
            return 0;
        }
    }
}
