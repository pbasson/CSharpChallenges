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
    [InlineData(-10, -2, 5)]
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

    [Theory]
    [InlineData(5, 25)]
    [InlineData(-3, 9)]
    [InlineData(0, 0)]
    public void Square_ShouldReturnExpectedValue(int a, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Square(a);

        // Assert
        Assert.Equal(expected, result); 
    }

    [Theory]
    [InlineData(2, 8)]
    [InlineData(-3, -27)]
    [InlineData(0, 0)]
    public void Cube_ShouldReturnExpectedValue(int a, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Cube(a); 
        // Assert
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(-3, 3, -27)]
    [InlineData(5, 0, 1)]
    [InlineData(0, 0, 1)]
    public void Power_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Power(a, b); 

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(25, 5)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    public void SquareRoot_ShouldReturnExpectedValue(int a, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.SquareRoot(a);
     
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SquareRoot_ShouldThrowArgumentException_WhenInputIsNegative()
    {
        // Arrange && Act && Assert
        Assert.Throws<ArgumentException>(() => _mathCalc.SquareRoot(-1));
    }

    [Theory]
    [InlineData(-5, 5)]
    [InlineData(5, 5)]
    [InlineData(0, 0)]
    public void Absolute_ShouldReturnExpectedValue(int a, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Absolute(a);
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 5)]
    [InlineData(-2, 4, 4)]
    [InlineData(0, 0, 0)]
    public void Max_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Max(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 3)]
    [InlineData(-2, 4, -2)]
    [InlineData(0, 0, 0)]
    public void Min_ShouldReturnExpectedValue(int a, int b, int expected)
    {
        // Arrange && Act
        var result = _mathCalc.Min(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 4)]
    [InlineData(-2, 4, 1)]
    [InlineData(0, 0, 0)]
    public void Average_ShouldReturnExpectedValue(int a, int b, double expected)
    {
        // Arrange && Act
        var result = _mathCalc.Average(a, b);
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new double[] { 1, -3, 2 }, new double[] { 2, 1 })]
    public void QuadraticEquation_ShouldReturnExpectedValue(double[] values, double[] expected)
    {
        // Arrange && Act
        var result = _mathCalc.QuadraticEquation(values[0], values[1], values[2]);
        
        // Assert
        Assert.Equal(expected[0], result.Item1);
        Assert.Equal(expected[1], result.Item2);  
    }
}