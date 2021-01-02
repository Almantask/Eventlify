using System;
using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Handlers.Command;
using Eventlify.Application.UseCases;
using Eventlify.Tests.Common;
using FluentAssertions;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Application.Tests.UseCases
{
    public class SaveEventsUseCaseTests
    {
        [Fact]
        public void New_When_NullCommandHandler_ThrowsArgumentNullException()
        {
            ISaveDomainEventsHandler handler = null;

            Action @new = () => new SaveEventUseCase(handler);

            @new.Should().ThrowArgumentNullException(nameof(ISaveDomainEventsHandler));
        }

        [Fact]
        public void SaveEvents_When_NullCommand_Throws_ArgumentNullException()
        {
            SaveDomainEventsCommand command = null;
            var useCase = new SaveEventUseCase(Mock.Of<ISaveDomainEventsHandler>());

            Func<Task> saveEvents = async () => await useCase.SaveEvents(command);

            saveEvents.Should().ThrowArgumentNullException(nameof(SaveDomainEventsCommand));
        }

        [Fact]
        public async Task SaveEvents_Calls_SaveEventHandler()
        {
            var handlerMock = new Mock<ISaveDomainEventsHandler>();
            var useCase = new SaveEventUseCase(handlerMock.Object);
            var command = Any<SaveDomainEventsCommand>();

            await useCase.SaveEvents(command);

            handlerMock.Verify(h => h.Handle(command));
        }
    }
}
