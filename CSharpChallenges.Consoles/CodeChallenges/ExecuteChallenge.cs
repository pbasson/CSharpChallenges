namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class ExecuteChallenge {

        public ExecuteChallenge()
        {
            // var test = Console.ReadLine();
            LinqChallenges_Execute("");
        }

        public List<string> AllPrefixes_Execute() {
            return new StringChallenge().AllPrefixes(CodeVariable.PrefixLength, CodeVariable.Words);
        }
        
        public void FindPalindromeInString_Execute() {
            new PalindromeChallenge().FindPalindromeInString(CodeVariable.Palindrome);
        }

        public void LinqChallenges_Execute(string str) {
            new PalindromeChallenge().FindPalindromeInString( !(string.IsNullOrEmpty(str)) ? str : (CodeVariable.Palindrome));
        }

    }

    public static class CodeVariable {
        public static readonly int PrefixLength = 3;
        public static readonly IEnumerable<string> Words = ["flow", "flea", "Feast", "fast", "Float", "FARTHER", "Father", "fatTER"];

        public static readonly string Palindrome = "RACecar";
    }
}