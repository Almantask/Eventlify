using Eventlify.Api.Mapping;
using Eventlify.Api.Messages;
using Eventlify.Application.Commands;
using Eventlify.Tests.Common;
using Xunit;

namespace Eventlify.Api.Tests.Unit.Mapping
{
    public class SaveDomainEventsRequestToCommandProfileTests
    {
        [Fact]
        public void Map_ReturnsExpected()
        {
            var profile = new SaveDomainEventsRequestToCommandProfile();

            profile.VerifyMapping<SaveDomainEventsRequest, SaveDomainEventsCommand>();
        }
    }
}
