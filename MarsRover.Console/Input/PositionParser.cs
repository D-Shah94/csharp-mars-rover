using MarsRover.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.Input
{
    public class PositionParser
    {

        public static Position? Parse(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var parts = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3
                && int.TryParse(parts[0], out int maxX)
                && int.TryParse(parts[1], out int maxY)
                && Enum.TryParse<CardinalDirection>(parts[2], ignoreCase: true, out var direction)
                && Enum.IsDefined(typeof(CardinalDirection), direction))
            {
                return (maxX >= 0 && maxY >= 0) ? new Position(maxX, maxY, direction) : null;
            }

            return null;
        }

    }

}