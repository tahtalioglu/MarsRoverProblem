using MarsRoverProblem;
using MarsRoverProblem.Tests;
using Xunit;

namespace MarsRoverProbem.Tests
{
    public class BuilderTests : TestBase
    {
        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" }, "1 2 N")]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRM" }, "3 3 E")]
        public void BuilderTest(string[] input, string expected)
        {
            var sut = new RoverBuilder();

            var rover = sut.Build(input[1], input[0]);
            // Act
            var actual = rover.GetLastPosition();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
