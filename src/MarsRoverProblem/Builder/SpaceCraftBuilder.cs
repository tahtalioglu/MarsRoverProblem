using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public abstract class SpaceCraftBuilder
    {
        public abstract IRover Build(string startPosition, string plateauMarginPosition);
    }
}
