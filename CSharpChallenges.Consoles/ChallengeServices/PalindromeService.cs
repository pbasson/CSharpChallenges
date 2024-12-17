using CSharpChallenges.Consoles.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ExecuteChallenges
{
    public class PalindromeService
    {
        public void FindPalindromeInString_Execute(string str)
        {
            new PalindromeChallenge().FindPalindromeInString(!string.IsNullOrEmpty(str) ? str : CodeVariable.Palindrome);
        }
    }
}