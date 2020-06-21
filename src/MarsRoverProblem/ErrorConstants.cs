using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public static class ErrorConstants
    {
        public const string PlateauCoordinatesNotExist = "Invalid input because no x or y position to create surface array.";

        public const string InvalidStartingDestination = "Invalid input because the starting destination doesn't exist";

        public const string CommandsNotExists = "Command not exists";

        public const string UnappropriateCommand = "Invalid input because Command is unappropriate";

        public const string PlateaurCoordinatesOutOfBounds = "Position can not be beyond bounderies (0 , 0) and ({0} , {1})";
    }
}
