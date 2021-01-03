using System.Collections.Generic;

namespace Eventlify.Api.Messages
{
    public class SaveDomainEventsRequest
    {
        public IEnumerable<DomainEventDto> DomainEvents;
    }
}
