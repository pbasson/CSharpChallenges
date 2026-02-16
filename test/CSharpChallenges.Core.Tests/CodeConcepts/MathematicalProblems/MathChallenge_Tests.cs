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

    
}

