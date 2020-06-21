using MarsRoverProblem;
using MarsRoverProblem.Tests;
using Xunit;

namespace MarsRoverProbem.Tests
{
    public class InputValidatorTests : TestBase
    {
        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" }, true)]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRM" }, true)]
        [InlineData(new string[] { }, false)]
        [InlineData(new string[] { "5 5", "3 3", "MMRMMRMRRM" }, false)]
        [InlineData(new string[] { "5 5", "3 3", "WASDRRRLLLSDD" }, false)]
        [InlineData(new string[] { ",,,,rrrr", "3 3", "MMRMMRMRRM" }, false)]
        [InlineData(new string[] { "5", "3 3", "MMRMMRMRRM" }, false)]
        [InlineData(new string[] { "5 5", "1 2 N", "" }, false)]
        public void InputValidationTests(string[] input, bool expected)
        {
            // Arrange
            var sut = new InputValidator();

            // Act
            var actual = sut.Validate(new InputRequest()
            {
                MaxPoints = input.Length == 3 ? input[0] : string.Empty,
                StartPositions = input.Length == 3 ? input[1] : string.Empty,
                Command = input.Length == 3 ? input[2] : string.Empty
            });

            // Assert
            Assert.Equal(expected, actual.IsValid);
        }
    }
}
