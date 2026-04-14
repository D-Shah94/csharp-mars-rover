using MarsRover.Console.Models;

namespace MarsRover.Console.Input
{
    public class InstructionParser()
    {
        public static List<Instruction> Parse(string input)
        {
            var instructions = new List<Instruction>();

            if (string.IsNullOrWhiteSpace(input))
            {
                return instructions;
            }

            foreach (char c in input.ToUpper())
            {
                if (Enum.TryParse<Instruction>(c.ToString(), true, out var instruction))
                {
                    instructions.Add(instruction);
                }
            }
            return instructions;
        }
    }
}