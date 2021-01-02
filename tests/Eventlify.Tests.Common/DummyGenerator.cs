using AutoFixture;

namespace Eventlify.Tests.Common
{
    public static class DummyGenerator
    {
        private static readonly Fixture Fixture = new Fixture();

        public static T Any<T>() => Fixture.Create<T>();
    }
}
