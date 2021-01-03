using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Eventlify.Tests.Common.Api
{
    public class ClientFixture<TStartup> : IDisposable where TStartup : class
    {
        public HttpClient Client { get; }

        public ClientFixture()
        {
            var factory = new WebApplicationFactory<TStartup>();
            Client = factory.CreateClient();
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
