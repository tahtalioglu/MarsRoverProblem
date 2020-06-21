using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class CommandFactory
    {
        public static ICommand CreateCommand(Movements movements, IRover rover)
        {
            switch (movements)
            {
                case Movements.Left:
                    return new RotateLeftCommand(rover);

                case Movements.Right:
                    return new RotateRightCommand(rover);

                case Movements.Move:
                    return new MoveForwardCommand(rover);

                default:
                    return new NullObjectCommand();
            }
        }


    }
}
