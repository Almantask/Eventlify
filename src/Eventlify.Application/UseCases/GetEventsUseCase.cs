using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers;
using Eventlify.Application.Models;

namespace Eventlify.Application.UseCases
{
    public interface IGetEventsUseCase
    {
        /// <summary>
        /// Gets all events.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DomainEvent>> Execute();
    }

    public class GetEventsUseCase : IGetEventsUseCase
    {
        private IDomainEventHandlers.IGetDomainEvents _getDomainEventsHandler;

        public GetEventsUseCase(IDomainEventHandlers.IGetDomainEvents getDomainEventsHandler) => this._getDomainEventsHandler = getDomainEventsHandler;

        public Task<IEnumerable<DomainEvent>> Execute()
        {
           return _getDomainEventsHandler.Handle();
        }
    }
}
