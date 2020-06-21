using System.Collections.Generic;
using FluentValidation;
using System.Linq;

namespace MarsRoverProblem
{
    public class InputValidator : BaseValidator<InputRequest>
    {
        public List<string> Directions = new List<string>() { "N", "E", "S", "W" };

        public List<string> Commands = new List<string>() { "L", "R", "M" };

        public InputValidator()
        {
            RuleFor(p => p.MaxPoints).Must(q => !string.IsNullOrEmpty(q)).WithMessage(ErrorConstants.PlateauCoordinatesNotExist);

            RuleFor(p => p.MaxPoints).Must(q => q.Split(' ')?.Count() == 2).WithMessage(ErrorConstants.PlateauCoordinatesNotExist);

            RuleFor(p => p.StartPositions).Must(q => q.Split(' ')?.Count() == 3).WithMessage(ErrorConstants.InvalidStartingDestination);

            RuleFor(p => p.StartPositions).Must(q => Directions.Contains(q.Split(' ')[2])).When(r => r.StartPositions.Split(' ')?.Count() == 3).WithMessage(ErrorConstants.InvalidStartingDestination);

            RuleFor(p => p.Command).Must(q => !string.IsNullOrEmpty(q)).WithMessage(ErrorConstants.CommandsNotExists);

            RuleFor(p => p.Command).Must(q => IsCommandLettersValid(q)).WithMessage(ErrorConstants.UnappropriateCommand);
        }

        private bool IsCommandLettersValid(string command)
        {
            int i = 0;

            bool isValid = true;

            while (i < command.Length && isValid)
            {
                if (!Commands.Contains(command[i].ToString()))
                {
                    isValid = false;
                }

                i++;
            }

            return isValid;
        }
    }
}
