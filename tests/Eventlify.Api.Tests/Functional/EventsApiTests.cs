using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Queries;
using Eventlify.Tests.Common;
using Eventlify.Tests.Common.Api;
using Newtonsoft.Json;
using Xunit;

namespace Eventlify.Api.Tests.Functional
{
    [Collection(ApiTests.Alias)]
    public class EventsApiTests 
    {
        protected HttpClient Client { get; }

        public EventsApiTests(ClientFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task PostQuery_Returns_Ok()
        {
            var content = new StringContent(JsonConvert.SerializeObject(DummyGenerator.Any<GetDomainEventsQuery>()), Encoding.Default, "application/json");

            var response = await Client.PostAsync("/api/events/query", content);

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Get_Returns_Ok()
        {
            var content = new StringContent(JsonConvert.SerializeObject(DummyGenerator.Any<SaveDomainEventsCommand>()), Encoding.Default, "application/json");

            var response = await Client.PostAsync("/api/events", content);

            response.EnsureSuccessStatusCode();
        }
    }
}
