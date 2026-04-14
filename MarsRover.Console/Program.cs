// See https://aka.ms/new-console-template for more information
using MarsRover.Console.Input;
using MarsRover.Console.Models;
//using MarsRover.Console.Logic;

Console.WriteLine("Hello, World!");
//5 5
//1 2 N
//LMLMLMLMM
//3 3 E
//MMRMMRMRRM

Console.WriteLine(PlateauParser.Parse("5 5"));

Console.WriteLine(PositionParser.Parse("1 2 N"));

foreach (var x in InstructionParser.Parse("LMLMLMLMM"))

{
    Console.WriteLine(x);
};

Console.WriteLine(PositionParser.Parse("3 3 E"));

foreach (var x in InstructionParser.Parse("MMRMMRMRRM"))
{
    Console.WriteLine(x);
}
;