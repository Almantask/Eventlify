using System;
using Hellang.Middleware.ProblemDetails;
using Microsoft.Extensions.DependencyInjection;

namespace Eventlify.Api.Bootsrap
{
    public static class HttpResponse
    {
        public static void AddExceptionToStatusCodeMappings(this IServiceCollection services)
        {
            services
                .Map<NotSupportedException>(400);
        }

        private static IServiceCollection Map<TException>(this IServiceCollection services, int statusCode) where TException : Exception
        {
            services.AddProblemDetails(opt => opt.MapToStatusCode<TException>(statusCode));

            return services;
        }
    }
}
