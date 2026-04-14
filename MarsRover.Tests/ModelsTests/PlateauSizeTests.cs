using MarsRover.Console.Models;

namespace MarsRover.Tests.ModelsTests;

public class PlateauSizeTests
{

    [TestCase(5, 5)]
    [TestCase(10, 20)]

    [Test]
    public void PlateauSize_ShouldCorrectlyAssignDimensions(int inputX, int inputY)
    {
        // Arrange

        // Act
        var plateau = new PlateauSize(inputX, inputY);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(plateau.MaxX, Is.EqualTo(inputX), "The MaxX property was not assigned correctly.");
            Assert.That(plateau.MaxY, Is.EqualTo(inputY), "The MaxY property was not assigned correctly.");

        });

    }



    [Test]
    public void Two_Plateaus_With_Same_Dimensions_Should_Be_Equal()
    {

        // Act
        var plateau1 = new PlateauSize(5, 5);
        var plateau2 = new PlateauSize(5, 5);

        // Assert
        Assert.That(plateau1, Is.EqualTo(plateau2));

    }
}
