using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.InputLayer
{
    public record PlateauSize(int X, int Y)
    {
        public int[,] Grid { get; init; } = new int[X, Y];
    }
}
