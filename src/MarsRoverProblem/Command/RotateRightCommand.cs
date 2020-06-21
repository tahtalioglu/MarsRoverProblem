using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class RotateRightCommand : ICommand
    {
        public IRover _rover;
        public RotateRightCommand(IRover rover)
        {
            _rover = rover;
        }
        public void Move()
        {
            _rover.RotateRight();
        }
    }
}
