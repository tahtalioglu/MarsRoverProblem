using System;

namespace MarsRoverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give The Appropriate Coordinates");

            var maxPoints = Console.ReadLine().Trim();

            var startPositions = Console.ReadLine().Trim();

            var moves = Console.ReadLine().ToUpper();

            try
            {

                InputRequest inputRequest = new InputRequest()
                {
                    MaxPoints = maxPoints,
                    StartPositions = startPositions,
                    Command = moves
                };

                BaseValidator<InputRequest> validations = new InputValidator();
                validations.Validate(inputRequest);

                SpaceCraftBuilder builder = new RoverBuilder();
                var rover = builder.Build(startPositions, maxPoints);

                CommandInvoker commandInvoker = new CommandInvoker(rover, moves);
                commandInvoker.Invoke();

                string roverLastPosition = rover.GetLastPosition();

                Console.WriteLine(roverLastPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
