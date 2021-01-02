using System;
using System.Linq;
using AutoFixture;

namespace Eventlify.Tests.Common
{
    internal class FixtureConstant : Fixture
    {
        public FixtureConstant()
        {
            Behaviors.Add(new OmitOnRecursionBehavior());
            var behavior = this.Behaviors.Single(b => typeof(ThrowingRecursionBehavior) == b.GetType());
            Behaviors.Remove(behavior);
            this.Freeze<string>();
            this.Freeze<int>();
            this.Freeze<bool>();
            this.Freeze<long>();
            this.Freeze<double>();
            this.Freeze<byte>();
            this.Freeze<DateTime>();
            this.Freeze<Guid>();
        }
    }
}
