using MarsRover.Console.Models;

namespace MarsRover.Console.Input
{
    public static class PlateauParser
    {
        public static PlateauSize? Parse(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var parts = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 2 
                && int.TryParse(parts[0], out int maxX) 
                && int.TryParse(parts[1], out int maxY)
                )
            {
                return (maxX >= 0 && maxY >= 0 ? new PlateauSize(maxX, maxY) : null);
            }

            return null;
        }


    }
}
