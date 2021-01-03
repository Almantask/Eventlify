using Eventlify.Tests.Common.Api;
using Xunit;

namespace Eventlify.Api.Tests.Functional.Base
{
    [CollectionDefinition(ApiTests.Alias)]
    public class EventlifyApiCollection : ICollectionFixture<ClientFixture<Startup>>
    {
    }
}