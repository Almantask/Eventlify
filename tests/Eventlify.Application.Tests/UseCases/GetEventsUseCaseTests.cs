using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.Models;
using Eventlify.Application.Queries;
using Eventlify.Application.UseCases;
using FluentAssertions;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Application.Tests.UseCases
{
    public class GetEventsUseCaseTests
    {
        [Fact]
        public async Task Execute_Returns_EventsFromHandler()
        {
            var expectedEvent = Any<List<DomainEvent>>();
            var query = Any<GetDomainEventsQuery>();
            var handlerMock = new Mock<IGetDomainEventsHandler>();
            handlerMock
                .Setup(h => h.Handle(query))
                .ReturnsAsync(expectedEvent);
            var useCase = new GetEventsUseCase(handlerMock.Object);

            var events = await useCase.GetEvents(query);

            events.Should().BeEquivalentTo(expectedEvent);
        }
    }
}
