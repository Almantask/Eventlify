using System.Collections.Generic;
using Eventlify.Application.Queries;
using Eventlify.SharedKernel.Handlers;

namespace Eventlify.Application.Handlers.Query
{
    public interface IGetDomainEventsHandler : IQueryHandler<GetDomainEventsQuery, IEnumerable<Models.DomainEvent>>
    {
    }
}
