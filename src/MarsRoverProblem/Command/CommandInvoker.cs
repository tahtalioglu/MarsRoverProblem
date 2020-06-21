using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class CommandInvoker
    {
        private IRover _rover;
        private string _moves;
        public CommandInvoker(IRover rover, string moves)
        {
            _rover = rover;
            _moves = moves;
        }
        public void Invoke()
        {
            foreach (var c in _moves)
            {
                var command = CommandFactory.CreateCommand((Movements)c, _rover);
                command.Move();
            }
        }
    }
}
