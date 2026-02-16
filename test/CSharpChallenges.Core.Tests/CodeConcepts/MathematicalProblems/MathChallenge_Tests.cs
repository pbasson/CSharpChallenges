namespace CSharpChallenges.Core.Tests.CodeConcepts.MathematicalProblems;

public class MathChallenge_Tests
{
    private readonly IMathChallenge _mathChallenge;

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
    [InlineData(new double[] { 1, -5, 6 }, new double[] { 3, 2 })]
    [InlineData(new double[] { 1, -3, 2 }, new double[] { 2, 1 })]
    public void FindRoots_ShouldReturnExpectedValues(double[] roots, double[] expectedRoots)
    {
        // Act
        var result = _mathChallenge.FindRoots(roots[0], roots[1], roots[2]);

        // Assert
        Assert.Equal(expectedRoots[0], result.Item1);
        Assert.Equal(expectedRoots[1], result.Item2);
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
        Assert.Equal(expectedValue, result);}
}

