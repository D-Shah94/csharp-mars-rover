using MarsRover.Console.Models;

namespace MarsRover.Tests.ModelsTests;

public class CardinalDirectionTests
{

    [TestCase(CardinalDirection.N, 0)]
    [TestCase(CardinalDirection.E, 1)]
    [TestCase(CardinalDirection.S, 2)]
    [TestCase(CardinalDirection.W, 3)]

    [Test]
    public void CardinalDirection_ShouldMapToSpecificIntegers(CardinalDirection direction, int expectedValue)
    {
        // Arrange & Act
        int actualValue = (int)direction;

        // Assert
        Assert.That(actualValue,Is.EqualTo(expectedValue));
    }


    [TestCase("N", CardinalDirection.N)]
    [TestCase("E", CardinalDirection.E)]
    [TestCase("S", CardinalDirection.S)]
    [TestCase("W", CardinalDirection.W)]

    [Test]
    public void CardinalDirection_ShouldParseFromValidStrings(string input, CardinalDirection expected)
    {
        // Arrange & Act
        var result = Enum.Parse<CardinalDirection>(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
