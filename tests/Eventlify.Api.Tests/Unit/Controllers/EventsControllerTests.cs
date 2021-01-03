using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Eventlify.Api.Controllers;
using Eventlify.Api.Messages;
using Eventlify.Application.UseCases;
using Eventlify.Tests.Common;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using static Eventlify.Tests.Common.DummyGenerator;

namespace Eventlify.Api.Tests.Unit.Controllers
{
    public class EventsControllerTests
    {
        private readonly EventsController _controller;
        private readonly Mock<IGetEventsUseCase> _getEventsUseCaseMock;
        private readonly Mock<ISaveEventUseCase> _saveEventUseCaseMock;
        private readonly Mock<IMapper> _mapper;

        public EventsControllerTests()
        {
            _getEventsUseCaseMock = new();
            _saveEventUseCaseMock = new();
            _mapper = new();
            _controller = new(_getEventsUseCaseMock.Object, _saveEventUseCaseMock.Object, _mapper.Object);
        }

        [Theory]
        [MemberData(nameof(InvalidCtorArgs))]
        public void Test1(IGetEventsUseCase getEventsUseCase, ISaveEventUseCase saveEventsUseCase, IMapper mapper, string expectedMissingArg)
        {
            Action @new = () => new EventsController(getEventsUseCase, saveEventsUseCase, mapper);

            @new.Should().ThrowArgumentNullException(expectedMissingArg);
        }

        // TODO: more detail.
        [Fact]
        public async Task Get_Returns_Ok()
        {
            var request = Any<GetDomainEventsRequest>();

            var result = await _controller.Get(request);

            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task Save_Returns_Ok()
        {
            var request = Any<SaveDomainEventsRequest>();

            var result = await _controller.Save(request);

            result.Should().BeOfType<OkResult>();
        }

        public static IEnumerable<object[]> InvalidCtorArgs
        {
            get
            {
                object[] args = {Mock.Of<IGetEventsUseCase>(), Mock.Of<ISaveEventUseCase>(), Mock.Of<IMapper>()};
                string[] missingArgs = {nameof(IGetEventsUseCase), nameof(ISaveEventUseCase), nameof(IMapper)};
                for (var index = 0; index < args.Length; index++)
                {
                    var invalidArgs = new object[args.Length + 1];
                    args.CopyTo(invalidArgs, 0);
                    invalidArgs[index] = null;
                    invalidArgs[^1] = missingArgs[index];
                    yield return invalidArgs;
                }
            }
        }
    }
}
