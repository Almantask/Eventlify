using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using AutoMapper;
using FluentAssertions;

namespace Eventlify.Tests.Common
{
    public static class MappingHelpers
    {
        private static FixtureConstant fixture = new FixtureConstant();

        /// <summary>
        /// Unit tests <see cref="IMapper"/> mapping.
        /// </summary>
        /// <typeparam name="TFrom">Type to map from.</typeparam>
        /// <typeparam name="TTo">Type to map to.</typeparam>
        /// <param name="mapper">Mapper with mapping configuration.</param>
        /// <param name="customizeIn">Function to customize input. Use when custom mapping is applied.</param>
        /// <param name="customizeOut">Function to customize output. Use when custom mapping is applied.</param>
        /// <remarks>
        /// <para>It's recommended to combine this with using static MappingHelpers.</para>
        /// </remarks>
        public static void VerifyMapping<TFrom, TTo>(this IMapper mapper, Action<TFrom> customizeIn = null, Action<TTo> customizeOut = null)
        {
            var input = fixture.Create<TFrom>();
            customizeIn?.Invoke(input);

            var expectedOutput = fixture.Create<TTo>();
            customizeOut?.Invoke(expectedOutput);

            var actualOutput = mapper.Map<TTo>(input);

            actualOutput.Should().BeEquivalentTo(expectedOutput);
        }
    }
}
