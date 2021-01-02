using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.Models;
using Eventlify.Application.Queries;

namespace Eventlify.Application.UseCases
{
    public interface IGetEventsUseCase
    {
        /// <summary>
        /// Gets all events.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DomainEvent>> GetEvents(GetDomainEventsQuery query);
    }

    public class GetEventsUseCase : IGetEventsUseCase
    {
        private readonly IGetDomainEventsHandler _getDomainEventsHandlerHandler;

        public GetEventsUseCase(IGetDomainEventsHandler getDomainEventsHandlerHandler)
        {
            _getDomainEventsHandlerHandler = getDomainEventsHandlerHandler;
        }

        public Task<IEnumerable<DomainEvent>> GetEvents(GetDomainEventsQuery query)
        {
           return _getDomainEventsHandlerHandler.Handle(query);
        }
    }
}
