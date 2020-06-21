using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class RoverBuilder : SpaceCraftBuilder
    {
        public override IRover Build(string startPosition, string plateauMarginPosition)
        {
            Position plateau = new Position()
            {
                X = Int32.Parse(plateauMarginPosition.Split(' ')[0]),
                Y = Int32.Parse(plateauMarginPosition.Split(' ')[1])
            };

            Position position = new Position()
            {
                X = Int32.Parse(startPosition.Split(' ')[0]),
                Y = Int32.Parse(startPosition.Split(' ')[1])
            };

            Direction direction = (Direction)Enum.Parse(typeof(Direction), startPosition.Split(' ')[2]);

            return new Rover(position, plateau, direction);
        }
    }
}
