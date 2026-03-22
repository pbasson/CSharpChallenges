namespace CSharpChallenges.Core.Tests.CodeConcepts.CoreAlgorithms;
    
public class StringChallenge_Test
{
    StringChallenge str = new();


    [Fact]
    public void GetSubString_Test()
    {
        var testString = "gdsfgdsfgdfefgrsadg";
        var testLength = 3;

        var result = str.GetSubString(testString, testLength);

        Assert.NotNull(result);
        Assert.NotEmpty(result); 
        Assert.Equal(testLength, result.Length);
    }


    [Theory]
    [InlineData("Hello world hello", 2)]
    [InlineData("Hello world hello war The          ", 4)]
    [InlineData("The quick brown fox jumps over the lazy dog", 8)]
    [InlineData("", 0)]
    [InlineData("  ", 0)]
    public void CountUniqueWords_Test(string input, int expected)
    {
        // Arrange && Act
        var result = str.CountUniqueWords(input);

        // Assert
        Assert.Equal(expected, result);
    }
}

