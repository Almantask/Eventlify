using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using AutoFixture.Kernel;

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
