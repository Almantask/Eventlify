using AutoMapper;
using Eventlify.Api.Controllers;
using Eventlify.Application.UseCases;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace Eventlify.Api.Tests.Integration
{
    public class StartupTests
    {
        [Fact]
        public void GetService_ForEveryController_ReturnsNotNull()
        {
            var services = new ServiceCollection();
            var startup = new Startup(Mock.Of<IConfiguration>());
            startup.ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var controller = serviceProvider.GetService<EventsController>();
            controller.Should().NotBeNull();
        }
    }
}
