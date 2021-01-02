using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventlify.Application.Handlers;
using Eventlify.Application.Models;

namespace Eventlify.Persistence.Mongo.Handlers
{
    // "Implementing" the interface
    public abstract class DomainEventHandlers : IDomainEventHandlers
    {
        public class SaveDomainEvent : IDomainEventHandlers.ISaveDomainEvent
        {
            public void Handle(DomainEvent command)
            {
                return;
            }
        }

        public class GetDomainEvents : IDomainEventHandlers.IGetDomainEvents
        {
            public Task<IEnumerable<DomainEvent>> Handle()
            {
                return Task.FromResult(Enumerable.Empty<DomainEvent>());
            }
        }
    }
}
