using Eventlify.Application.Handlers;
using Eventlify.Application.Models;

namespace Eventlify.Persistence.Mongo.Handlers
{
    public class SaveDomainEventHandler : DomainEventHandlers.ISaveDomainEvent
    {
        public void Handle(DomainEvent command)
        {
            throw new System.NotImplementedException();
        }
    }
}
