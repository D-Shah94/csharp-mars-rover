using MarsRover.Console.Input;
using MarsRover.Console.Models;

namespace MarsRover.Tests.InputTests;
public class PositionParserTests
{


    [TestCase("5 5 N", 5, 5, CardinalDirection.N)]
    [TestCase("10 20 S", 10, 20, CardinalDirection.S)]
    [TestCase("0 0 E", 0, 0, CardinalDirection.E)]

    [Test]
    public void Parse_ValidInput_ShouldReturnPosition(string rawInput, int xExpectedValue, int yExpectedValue, CardinalDirection expectedDirection)
    {

        // Act
        var parsedInput = PositionParser.Parse(rawInput);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(parsedInput, Is.Not.Null, "The parsed returned null for valid input");
            Assert.That(parsedInput?.X, Is.EqualTo(xExpectedValue), "The X coordinate was not parsed correctly.");
            Assert.That(parsedInput?.Y, Is.EqualTo(yExpectedValue), "The Y coordinate was not parsed correctly.");
            Assert.That(parsedInput?.FacingDirection, Is.EqualTo(expectedDirection), "The Cardinal Direction was not parsed correctly.");
        });
    }

    [TestCase("5 5 5")]
    [TestCase("5")]
    [TestCase("A B")]
    [TestCase("-1 5")]
    [TestCase("")]
    [TestCase(null)]
    [Test]
    public void Parse_InvalidInput_ShouldReturnNull(string? rawInput)
    {
        // Act
        var parsedInput = PositionParser.Parse(rawInput);

        // Assert
        Assert.That(parsedInput, Is.Null, $"The parser should return null for invalid input: '{rawInput}'");
    }

}
