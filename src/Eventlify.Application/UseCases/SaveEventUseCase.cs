using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Handlers.Command;

namespace Eventlify.Application.UseCases
{
    /// <summary>
    /// Save event use case.
    /// </summary>
    public interface ISaveEventUseCase
    {
        Task SaveEvents(SaveDomainEventsCommand saveDomainEventsCommand);
    }

    public class SaveEventUseCase : ISaveEventUseCase
    {
        private readonly ISaveDomainEventsHandler _handler;

        public SaveEventUseCase(ISaveDomainEventsHandler handler) => _handler= handler;

        public Task SaveEvents(SaveDomainEventsCommand saveDomainEventsCommand)
        {
            return _handler.Handle(saveDomainEventsCommand);
        }
    }
}
