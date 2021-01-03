using AutoMapper;
using Eventlify.Api.Messages;
using Eventlify.Application.Queries;

namespace Eventlify.Api.Mapping
{
    public class GetDomainEventsRequestToQueryProfile : Profile
    {
        public GetDomainEventsRequestToQueryProfile()
        {
            CreateMap<GetDomainEventsRequest, GetDomainEventsQuery>();
        }
    }
}
