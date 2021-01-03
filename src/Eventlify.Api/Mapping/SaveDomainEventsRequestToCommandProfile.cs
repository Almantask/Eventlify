using AutoMapper;
using Eventlify.Api.Messages;
using Eventlify.Application.Commands;
using Eventlify.Application.Models;

namespace Eventlify.Api.Mapping
{
    public class SaveDomainEventsRequestToCommandProfile : Profile
    {
        public SaveDomainEventsRequestToCommandProfile()
        {
            // Wrong ctor picked up
            CreateMap<DomainEventDto, DomainEvent>();
            CreateMap<SaveDomainEventsRequest, SaveDomainEventsCommand>();
        }
    }
}
