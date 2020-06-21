using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public interface IRover
    {
        void RotateRight();

        void RotateLeft();

        void MoveForward();

        string GetLastPosition();
    }
}
