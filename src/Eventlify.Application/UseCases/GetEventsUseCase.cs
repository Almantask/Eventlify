using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.Models;
using Eventlify.Application.Queries;
using Eventlify.SharedKernel.Validation;

namespace Eventlify.Application.UseCases
{
    public interface IGetEventsUseCase
    {
        /// <summary>
        /// Gets events by query.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DomainEvent>> GetEvents(GetDomainEventsQuery query);
    }

    public class GetEventsUseCase : IGetEventsUseCase
    {
        private readonly IGetDomainEventsHandler _getDomainEventsHandlerHandler;

        public GetEventsUseCase(IGetDomainEventsHandler handler)
        {
            Require.NotNull(handler);

            _getDomainEventsHandlerHandler = handler;
        }

        public Task<IEnumerable<DomainEvent>> GetEvents(GetDomainEventsQuery query)
        {
            Require.NotNull(query);
            // error handling
            // hook up with cache, logging and other components
            return _getDomainEventsHandlerHandler.Handle(query);
        } 
    }
}
