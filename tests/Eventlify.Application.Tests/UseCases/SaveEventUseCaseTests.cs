using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Handlers.Command;
using Eventlify.Application.Models;
using Eventlify.Application.UseCases;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Application.Tests.UseCases
{
    public class SaveEventUseCaseTests
    {
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
