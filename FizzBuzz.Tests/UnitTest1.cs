namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void GetMaxValue_WithValidArgument_ReturnsCorrectValue()
    {
        // Arrange
        var args = new[] { "15" };

        // Act
        var result = Program.GetMaxValue(args);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void GetMaxValue_WithNoArguments_ReturnsDefaultValue()
    {
        // Arrange
        var args = Array.Empty<string>();

        // Act
        var result = Program.GetMaxValue(args);

        // Assert
        Assert.Equal(100, result);
    }

    [Fact]
    public void GetMaxValue_WithNullOrWhiteSpaceArgument_ReturnsDefaultValue()
    {
        // Arrange & Act & Assert
        Assert.Equal(100, Program.GetMaxValue(new[] { "" }));
        Assert.Equal(100, Program.GetMaxValue(new[] { " " }));
        Assert.Equal(100, Program.GetMaxValue(new[] { "   " }));
    }

    [Fact]
    public void GetMaxValue_WithInvalidArgument_ReturnsDefaultValue()
    {
        // Arrange
        var args = new[] { "abc" };

        // Act
        var result = Program.GetMaxValue(args);

        // Assert
        Assert.Equal(100, result);
    }

    [Fact]
    public void GetMaxValue_WithZeroOrNegativeArgument_ReturnsDefaultValue()
    {
        // Arrange & Act & Assert
        Assert.Equal(100, Program.GetMaxValue(new[] { "0" }));
        Assert.Equal(100, Program.GetMaxValue(new[] { "-1" }));
        Assert.Equal(100, Program.GetMaxValue(new[] { "-10" }));
    }

    [Fact]
    public void GetMaxValue_WithValueGreaterThan100_ReturnsDefaultValue()
    {
        // Arrange
        var args = new[] { "101" };

        // Act
        var result = Program.GetMaxValue(args);

        // Assert
        Assert.Equal(100, result);
    }

    [Fact]
    public void GenerateFizzBuzz_WithSmallRange_ReturnsCorrectSequence()
    {
        // Arrange
        var maxValue = 15;

        // Act
        var results = Program.GenerateFizzBuzz(maxValue).ToArray();

        // Assert
        var expected = new[]
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "14", "FizzBuzz"
        };
        Assert.Equal(expected, results);
    }

    [Fact]
    public void GenerateFizzBuzz_WithSingleValue_ReturnsCorrectResult()
    {
        // Test single values
        Assert.Equal(new[] { "1" }, Program.GenerateFizzBuzz(1).ToArray());
        Assert.Equal(new[] { "1", "2" }, Program.GenerateFizzBuzz(2).ToArray());
        Assert.Equal(new[] { "1", "2", "Fizz" }, Program.GenerateFizzBuzz(3).ToArray());
        Assert.Equal(new[] { "1", "2", "Fizz", "4", "Buzz" }, Program.GenerateFizzBuzz(5).ToArray());
    }

    [Fact]
    public void GenerateFizzBuzz_WithMultiplesOf3_ReturnsFizz()
    {
        // Arrange & Act
        var results = Program.GenerateFizzBuzz(9).ToArray();

        // Assert
        Assert.Equal("Fizz", results[2]);  // 3
        Assert.Equal("Fizz", results[5]);  // 6
        Assert.Equal("Fizz", results[8]);  // 9
    }

    [Fact]
    public void GenerateFizzBuzz_WithMultiplesOf5_ReturnsBuzz()
    {
        // Arrange & Act
        var results = Program.GenerateFizzBuzz(10).ToArray();

        // Assert
        Assert.Equal("Buzz", results[4]);  // 5
        Assert.Equal("Buzz", results[9]);  // 10
    }

    [Fact]
    public void GenerateFizzBuzz_WithMultiplesOf15_ReturnsFizzBuzz()
    {
        // Arrange & Act
        var results = Program.GenerateFizzBuzz(30).ToArray();

        // Assert
        Assert.Equal("FizzBuzz", results[14]); // 15
        Assert.Equal("FizzBuzz", results[29]); // 30
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(5, 5)]
    [InlineData(10, 10)]
    [InlineData(100, 100)]
    public void GenerateFizzBuzz_WithVariousMaxValues_ReturnsCorrectCount(int maxValue, int expectedCount)
    {
        // Act
        var results = Program.GenerateFizzBuzz(maxValue).ToArray();

        // Assert
        Assert.Equal(expectedCount, results.Length);
    }
}