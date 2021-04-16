using System;
using System.Threading.Tasks;
using CakeConsole;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class ChuckNorrisTests
    {
        [Fact]
        public async Task TellJokeAsync_ShouldReturnJoke_WhenApiUrlIsCorrect()
        {
            var chuckNorris = new ChuckNorris();

            var joke = await chuckNorris.TellJokeAsync();

            joke.value.Should().NotBeEmpty();
        }
    }
}
