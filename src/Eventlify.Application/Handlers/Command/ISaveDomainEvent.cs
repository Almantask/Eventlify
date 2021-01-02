using Eventlify.Application.Commands;
using Eventlify.SharedKernel.Handlers;

namespace Eventlify.Application.Handlers.Command
{
    public interface ISaveDomainEventsHandler : ICommandHandler<SaveDomainEventsCommand>
    {
    }
}