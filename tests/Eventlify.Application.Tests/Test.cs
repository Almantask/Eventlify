using System;
using System.Collections.Generic;
using Eventlify.Application.Handlers;
using Eventlify.Application.Models;
using Eventlify.Application.UseCases;
using Moq;
using Xunit;

namespace Eventlify.Application.Tests
{
    public class GetEventsUseCaseTests
    {


        [Fact]
        public void Execute_Returns_EventsFromHandler()
        {
            var handlerMock = new Mock<IDomainEventHandlers.IGetDomainEvents>();
            handlerMock
                .Setup(h => h.Handle())
                .ReturnsAsync(new List<DomainEvent>());
            
            var useCase = new GetEventsUseCase(handlerMock.Object);

            useCase.Execute();

            
        }
    }
}
