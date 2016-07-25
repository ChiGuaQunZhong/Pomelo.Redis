using System.Collections.Generic;

namespace Pomelo.Redis
{
    internal interface IMultiMessage
    {
        IEnumerable<Message> GetMessages(PhysicalConnection connection);
    }
}
