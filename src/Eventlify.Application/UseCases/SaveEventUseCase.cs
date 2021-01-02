using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Handlers.Command;
using Eventlify.SharedKernel.Validation;

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

        public SaveEventUseCase(ISaveDomainEventsHandler handler)
        {
            Require.NotNull(handler);

            _handler = handler;
        }

        public Task SaveEvents(SaveDomainEventsCommand command)
        {
            Require.NotNull(command);

            return _handler.Handle(command);
        }
    }
}
