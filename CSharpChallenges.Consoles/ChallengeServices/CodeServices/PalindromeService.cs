using CSharpChallenges.Infrastructure.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ChallengeServices.CodeServices
{
    public class PalindromeService
    {
        public void FindPalindromeInString_Execute(string str)
        {
            new PalindromeChallenge().FindPalindromeInString(!string.IsNullOrEmpty(str) ? str : CodeVariableStruct.Palindrome);
        }
    }
}