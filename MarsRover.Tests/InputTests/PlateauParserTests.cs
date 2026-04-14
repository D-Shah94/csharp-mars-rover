using MarsRover.Console.Input;

namespace MarsRover.Tests.InputLayerTests;

public class PlateauParserTests
{
    [TestCase("5 5", 5, 5)]
    [TestCase("10 20", 10, 20)]
    [TestCase("0 0", 0, 0)]
    [Test]
    public void Parse_ValidInput_ShouldReturnPlateauSize(string rawInput, int xExpectedValue, int yExpectedValue)
    {
        // Arrange
        
        // Act
        var parsedInput = PlateauParser.Parse(rawInput);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(parsedInput, Is.Not.Null, "The parser returned null for valid input.");
            Assert.That(parsedInput?.MaxX, Is.EqualTo(xExpectedValue), "MaxX was not parsed correctly.");
            Assert.That(parsedInput?.MaxY, Is.EqualTo(yExpectedValue), "MaxX was not parsed correctly.");
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
        // Arrange

        // Act
        var parsedInput = PlateauParser.Parse(rawInput);

        // Assert
        Assert.That(parsedInput, Is.Null, $"The parser should return null for invalid input: '{rawInput}'");
    }


}