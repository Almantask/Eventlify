using Eventlify.Api.Mapping;
using Eventlify.Api.Messages;
using Eventlify.Application.Queries;
using Eventlify.Tests.Common;
using Xunit;

namespace Eventlify.Api.Tests.Unit.Mapping
{
    public class GetDomainEventsRequestToQueryProfileTests
    {
        [Fact]
        public void Map_Returns_Expected()
        {
            var profile = new GetDomainEventsRequestToQueryProfile();

            profile.VerifyMapping<GetDomainEventsRequest, GetDomainEventsQuery>();
        }
    }
}
