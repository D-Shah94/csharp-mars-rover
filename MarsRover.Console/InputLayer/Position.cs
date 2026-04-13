using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.InputLayer
{
    public class Position(int x, int y, CardinalDirection facingDirection)
    {
        public int X = x;
        public int Y = y;
        public CardinalDirection Direction = facingDirection;

    }

}
