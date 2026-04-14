using MarsRover.Console.Models;

namespace MarsRover.Tests.ModelsTests;

public class PositionTests
{

    // Arrange
    [TestCase(1, 2, CardinalDirection.N)]
    [TestCase(5, 4, CardinalDirection.E)]
    [TestCase(2, 3, CardinalDirection.S)]
    [TestCase(6, 1, CardinalDirection.W)]
    [Test]
    public void Position_Should_Correctly_Store_Coordinates_And_Direction(int startX, int startY, CardinalDirection startFacing)
    {
        // Act
        var currentPosition = new Position(startX, startY, startFacing);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(currentPosition.X, Is.EqualTo(startX), "The X property was not assigned correctly.");
            Assert.That(currentPosition.Y, Is.EqualTo(startY), "The Y property was not assigned correctly.");
            Assert.That(currentPosition.FacingDirection, Is.EqualTo(startFacing), "The FacingDirection property was not assigned correctly.");
        });

    }


    [Test]
    public void Positions_With_Different_Facing_Directions_Should_Not_Be_Equal()
    {
        // Arrange & Act
        var facingNorth = new Position(1, 1, CardinalDirection.N);
        var facingSouth = new Position(1, 1, CardinalDirection.S);

        // Assert
        Assert.That(facingNorth, Is.Not.EqualTo(facingSouth));

    }
}
