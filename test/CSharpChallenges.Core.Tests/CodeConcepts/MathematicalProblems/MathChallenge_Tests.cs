namespace CSharpChallenges.Core.Tests.CodeConcepts.MathematicalProblems;

public class MathChallenge_Tests
{
    private readonly MathChallenge _mathChallenge;

    public MathChallenge_Tests()
    {
        _mathChallenge = new MathChallenge();
    }

    [Theory]
    [InlineData(new double[] { 5, 100 }, DiscountType.Standard, 94)]
    [InlineData(new double[] { 5, 100 }, DiscountType.Seasonal, 88)]
    [InlineData(new double[] { 5, 100 }, DiscountType.Weight, 94)]
    [InlineData(new double[] { 15, 100 }, DiscountType.Weight, 82)]
    public void GetDiscountedPrice_ShouldReturnExpectedValue(double[] values, DiscountType discountType, double expectedValue)
    {
        // Act
        var result = _mathChallenge.GetDiscountedPrice(values[0], values[1], discountType);

        // Assert
        Assert.Equal(expectedValue, result);
    }


    [Theory]
    [InlineData(-1, 1)]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 5)]
    [InlineData(4, 14)]
    public void BracketCombinations_ShouldReturnExpectedValue(int num, int expectedValue)
    {
        // Act
        var result = _mathChallenge.BracketCombinations(num);   
    
        // Assert
        Assert.Equal(expectedValue, result);
    }

    [Theory]
    [InlineData(new int[] {1, 2, 3, 4}, 3)]
    [InlineData(new int[] {4, 4, 4}, -1 )]
    [InlineData(new int[] {3, 3}, -1 )]
    [InlineData(new int[] {5}, -1)]
    public void SecondLargest_ShouldReturnExpectedResult(int[] input, int expected)
    {
        // Arrange && Act
        var result = _mathChallenge.SecondLargest(input);

        // Arrange
        Assert.Equal(expected,result);  
    }

    [Theory]
    [InlineData(new int[] {100, -50, -100, 30}, 30)]
    [InlineData(new int[] {-50, 100 }, 100)]
    [InlineData(new int[] {-10, -20, -30}, 0)]
    [InlineData(new int[] {50, -10, -100, 20}, 20)]
    [InlineData(new int[] {0, 0, 0}, 0)]
    [InlineData(new int[] {}, 0)]
    public void GetFinalBalance_ShouldReturnExpectedResult(int[] input, int expected)
    {
        // Arrange && Act
        var result = _mathChallenge.GetFinalBalance(input);

        // Arrange
        Assert.Equal(expected,result);  
    }

    
}

