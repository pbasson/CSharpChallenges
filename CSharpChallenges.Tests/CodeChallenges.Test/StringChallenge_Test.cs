using CSharpChallenges.Consoles.CodeChallenges;

namespace CSharpChallenges.Tests;

public class StringChallenge_Test
{
    StringChallenge str = new StringChallenge();


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
}