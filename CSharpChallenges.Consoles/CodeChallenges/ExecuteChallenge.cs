namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class ExecuteChallenge {
        public List<string> AllPrefixes_Execute() {
            return new StringCode().AllPrefixes(CodeVariable.PrefixLength, CodeVariable.Words);
        }
        
        public void FindPalindromeInString_Execute() {
            new PalindromeChallenge().FindPalindromeInString(CodeVariable.Palindrome);
        }

    }

    public static class CodeVariable {
        public static readonly int PrefixLength = 4;
        public static readonly IEnumerable<string> Words = ["flow", "flea", "Feast", "fast", "Float", "FARTHER", "Father", "fatTER"];

        public static readonly string Palindrome = "RACecar";
    }
}