using AutoMapper;
using Eventlify.Api.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Eventlify.Api.Bootstrap
{
    public static class MappingBootstrap
    {
        public static void AddAutomapper(this IServiceCollection services)
        {
            var mapper = BuildConfig().CreateMapper();
            services.AddSingleton(mapper);
        }

        public static MapperConfiguration BuildConfig()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<GetDomainEventsRequestToQueryProfile>();
                cfg.AddProfile<SaveDomainEventsRequestToCommandProfile>();
            });

            return config;
        }
    }
}
