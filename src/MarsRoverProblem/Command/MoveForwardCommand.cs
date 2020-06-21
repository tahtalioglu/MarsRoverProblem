using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class MoveForwardCommand : ICommand
    {
        public IRover _rover;

        public MoveForwardCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Move()
        {
            _rover.MoveForward();
        }
    }
}
