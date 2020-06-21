using MarsRoverProblem;
using MarsRoverProblem.Tests;
using System;
using Xunit;

namespace MarsRoverProbem.Tests
{
    public class CommandInvokerTests : TestBase
    {
        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" }, "1 3 N")]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRM" }, "5 1 E")]
        public void CommandInvokerInbounds(string[] input, string expected)
        {
            SpaceCraftBuilder builder = new RoverBuilder();
            var rover = builder.Build(input[1], input[0]);

            CommandInvoker commandInvoker = new CommandInvoker(rover, input[2]);
            commandInvoker.Invoke();

            string roverLastPosition = rover.GetLastPosition();

            Assert.Equal(expected, roverLastPosition);
        }

        [Theory]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRMM" }, "Position can not be beyond bounderies (0 , 0) and (5 , 5)")]
        public void CommandInvokerOutbounds(string[] input, string expected)
        {
            SpaceCraftBuilder builder = new RoverBuilder();
            var rover = builder.Build(input[1], input[0]);

            CommandInvoker commandInvoker = new CommandInvoker(rover, input[2]);

            Action act = () => commandInvoker.Invoke();
            //assert
            var exception = Assert.Throws<Exception>(act);
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal(expected, exception.Message);


        }
    }
}
