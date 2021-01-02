using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers;
using Eventlify.Application.Models;
using Eventlify.Application.UseCases;
using FluentAssertions;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Application.Tests
{
    public class GetEventsUseCaseTests
    {
        [Fact]
        public async Task Execute_Returns_EventsFromHandler()
        {
            var expectedEvent = Any<List<DomainEvent>>();
            var handlerMock = new Mock<IDomainEventHandlers.IGetDomainEvents>();
            handlerMock
                .Setup(h => h.Handle())
                .ReturnsAsync(expectedEvent);
            var useCase = new GetEventsUseCase(handlerMock.Object);

            var events = await useCase.Execute();

            events.Should().BeEquivalentTo(expectedEvent);
        }
    }
}
