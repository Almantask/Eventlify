using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eventlify.Application.Handlers.Query;
using Eventlify.Application.Models;
using Eventlify.Application.Queries;
using Eventlify.Application.UseCases;
using Eventlify.Tests.Common;
using FluentAssertions;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Application.Tests.UseCases
{
    public class GetEventsUseCaseTests
    {
        [Fact]
        public void New_When_NullHandler_Throws_ArgumentNullException()
        {
            IGetDomainEventsHandler handler = null;
            
            Action @new = () => new GetEventsUseCase(handler);

            @new.Should().ThrowArgumentNullException(nameof(IGetDomainEventsHandler));
        }

        [Fact]
        public void GetEvents_When_NullQuery_Throws_ArgumentNullException()
        {
            GetDomainEventsQuery query = null;
            var useCase = new GetEventsUseCase(Mock.Of<IGetDomainEventsHandler>());

            Func<Task> getEvents = async () => await useCase.GetEvents(query);

            getEvents.Should().ThrowArgumentNullException(nameof(GetDomainEventsQuery));
        }

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
