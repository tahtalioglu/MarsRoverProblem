using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class RotateLeftCommand : ICommand
    {
        public IRover _rover;
        public RotateLeftCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Move()
        {
            _rover.RotateLeft();
        }
    }
}
