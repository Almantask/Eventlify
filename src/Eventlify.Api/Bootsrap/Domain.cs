using Eventlify.Application.Handlers.Command;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.UseCases;
using Eventlify.Persistence.Mongo.Handlers.Command;
using Eventlify.Persistence.Mongo.Handlers.Query;
using Microsoft.Extensions.DependencyInjection;

namespace Eventlify.Api.Bootsrap
{
    public static class Domain
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<ISaveEventUseCase, SaveEventUseCase>();
            services.AddTransient<ISaveDomainEventsHandler, SaveDomainEventHandler>();
            services.AddTransient<IGetEventsUseCase, GetEventsUseCase>();
            services.AddTransient<IGetDomainEventsHandler, GetDomainEventsHandler>();
        }
    }
}
