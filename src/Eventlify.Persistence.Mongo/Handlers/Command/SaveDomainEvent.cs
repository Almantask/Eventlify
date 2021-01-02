using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Handlers.Command;

namespace Eventlify.Persistence.Mongo.Handlers.Command
{
    public class SaveDomainEventHandler : ISaveDomainEventsHandler
    {
        public Task Handle(SaveDomainEventsCommand command)
        {
            return Task.CompletedTask;
        }
    }
}
