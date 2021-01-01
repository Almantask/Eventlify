using System.Collections.Generic;
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
                throw new System.NotImplementedException();
            }
        }

        public class GetDomainEvents : IDomainEventHandlers.IGetDomainEvents
        {
            public Task<IEnumerable<DomainEvent>> Handle()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
