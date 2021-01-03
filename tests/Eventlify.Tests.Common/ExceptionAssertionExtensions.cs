using System;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Specialized;

namespace Eventlify.Tests.Common
{
    public static class ExceptionAssertionExtensions
    {
        public static void ThrowArgumentNullException<TTask, TAssertions>(this AsyncFunctionAssertions<TTask, TAssertions> asyncErrorAssertion, string argName)
            where TTask : Task
            where TAssertions : AsyncFunctionAssertions<TTask, TAssertions>
        {
            asyncErrorAssertion
                .ThrowAsync<ArgumentNullException>().Result
                .Which.ParamName.Should().Be(argName);
        }

        public static void ThrowArgumentNullException<TDelegate, TAssertions>(this DelegateAssertions<TDelegate, TAssertions> delegateErrorAssertion, string argName)
            where TDelegate : Delegate
            where TAssertions : DelegateAssertions<TDelegate, TAssertions>
        {
            delegateErrorAssertion
                .Throw<ArgumentNullException>()
                .Which.ParamName.Should().Be(argName);
        }
    }
}
