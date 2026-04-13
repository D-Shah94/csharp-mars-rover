using MarsRover.Console.InputLayer;

namespace MarsRover.Tests;

public class InstructionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(Instruction.L, 0)]
    [TestCase(Instruction.R, 1)]
    [TestCase(Instruction.M, 2)]

    [Test]
    public void Instruction_ShouldMapToSpecificIntegers(Instruction instruction, int expectedValue)
    {
        // Arrange & Act
        int actualValue = (int)instruction;

        // Assert
        Assert.That(actualValue, Is.EqualTo(expectedValue));
    }

    [TestCase("L", Instruction.L)]
    [TestCase("R", Instruction.R)]
    [TestCase("M", Instruction.M)]


    [Test]
    public void Instruction_ShouldParseFromValidString(string input, Instruction expected)
    {
        // Act
        var result = Enum.Parse<Instruction>(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
