using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.InputLayer
{
    public class Position(int x, int y, CardinalDirection facingDirection)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public CardinalDirection FacingDirection { get; set; } = facingDirection;


        // Tuple syntax for 3D Multidimensional-array
        public (int x, int y, int dir) CoordatesAndOrientation => (X, Y, (int)FacingDirection);

    }

}
