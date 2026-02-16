namespace CSharpChallenges.Core.Tests.CodeConcepts.MathematicalProblems;

public class MathematicalCalculations_Tests
{
    private readonly MathematicalCalculations _mathCalc;

    public MathematicalCalculations_Tests()
    {
        _mathCalc = new MathematicalCalculations();
    }

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-2, 4, 2)]
    [InlineData(0, 0, 0)]
    public void Add_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Add(a, b);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-2, 4, -6)]
    [InlineData(0, 0, 0)]
    public void Subtract_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(-2, 4, -8)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -1, 1)]
    public void Multiply_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(-8, 4, -2)]
    [InlineData(5, 2, 2.5)]
    public void Divide_ShouldReturnExpectedValue(int a, int b, double expected)
    {
        // Arrange && Act
        var result = _mathCalc.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ShouldReturnFalse_WhenDividingByZero()
    {
        // Arrange && Act && Assert
        Assert.Throws<DivideByZeroException>(() => _mathCalc.Divide(5, 0));
    }


    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-8, 4, 0)]
    [InlineData(5, 2, 1)]
    public void Modulus_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Modulus(a, b);

        // Assert
        Assert.Equal(expected, result);     
    }

}