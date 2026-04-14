using MarsRover.Console.Models;
using MarsRover.Console.Input;

namespace MarsRover.Tests.InputTests;

public class InstructionParserTests
{

    [Test]
    public void Parse_ValidString_ShouldReturnCorrectSequence()
    {
        // Arrange
        string rawInput = "LMR";
        var expected = new List<Instruction> { Instruction.L, Instruction.M, Instruction.R };

        // Act
        var result = InstructionParser.Parse(rawInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected), "The instruction sequence was not mapped correctly.");

    }

    [TestCase("lml", 3)] // Lowercase should work
    [TestCase("L M R", 3)] // Spaces might be present
    [Test]
    public void Parse_VariedInput_ShouldHandleFormatting(string rawInput, int expectedCount)
    {

        // Act
        var result = InstructionParser.Parse(rawInput);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expectedCount));
    }



    [Test]
    public void Parse_InvalidCharacters_ShouldBeIgnored()
    {
        // Arrange
        string rawInput = "L!M?R";
        var expected = new List<Instruction> { Instruction.L, Instruction.M, Instruction.R };

        // Act
        var result = InstructionParser.Parse(rawInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected), "The parser failed to filter out invalid characters.");

    }


    [Test]
    public void Parse_EmptyOrNull_ShouldReturnEmptyList()
    {
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(InstructionParser.Parse(""), Is.Empty);
            Assert.That(InstructionParser.Parse(null), Is.Empty);
        });

    }
}