using Eventlify.Application.Handlers;
using Eventlify.Application.UseCases;
using Eventlify.Persistence.Mongo.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace Eventlify.Api.Bootsrap
{
    public static class Domain
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<ISaveEventUseCase, SaveEventUseCase>();
            services.AddTransient<IDomainEventHandlers.ISaveDomainEvent, DomainEventHandlers.SaveDomainEvent>();
            services.AddTransient<IGetEventsUseCase, GetEventsUseCase>();
            services.AddTransient<IDomainEventHandlers.IGetDomainEvents, DomainEventHandlers.GetDomainEvents>();
        }
    }
}
