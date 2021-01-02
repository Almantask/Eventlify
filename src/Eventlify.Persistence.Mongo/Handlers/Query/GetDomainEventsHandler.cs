using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.Models;
using Eventlify.Application.Queries;

namespace Eventlify.Persistence.Mongo.Handlers.Query
{
    public class GetDomainEventsHandler : IGetDomainEventsHandler
    {
        public Task<IEnumerable<DomainEvent>> Handle(GetDomainEventsQuery query)
        {
            return Task.FromResult(Enumerable.Empty<DomainEvent>());
        }
    }
}