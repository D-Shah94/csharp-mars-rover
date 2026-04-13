using MarsRover.Console.InputLayer;
using Shouldly;
namespace MarsRover.Tests;


public class CardinalDirectionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(CardinalDirection.N, 0)]
    [TestCase(CardinalDirection.S, 1)]
    [TestCase(CardinalDirection.W, 2)]
    [TestCase(CardinalDirection.E, 3)]

    [Test]
    public void CardinalDirection_ShouldMapToSpecificIntegers(CardinalDirection direction, int expectedValue)
    {
        // Arrange & Act
        int actualValue = (int)direction;

        // Assert
        Assert.That(actualValue,Is.EqualTo(expectedValue));
    }


    [TestCase("N", CardinalDirection.N)]
    [TestCase("S", CardinalDirection.S)]
    [TestCase("W", CardinalDirection.W)]
    [TestCase("E", CardinalDirection.E)]

    [Test]
    public void CardinalDirection_ShouldParseFromValidStrings(string input, CardinalDirection expected)
    {
        // Act
        var result = Enum.Parse<CardinalDirection>(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
