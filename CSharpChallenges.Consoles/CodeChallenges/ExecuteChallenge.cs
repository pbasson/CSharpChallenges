namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class ExecuteChallenge {

        public ExecuteChallenge()
        {
            // var test = Console.ReadLine();
            GetEvenNumbersFromList_Execute();
        }

        public List<string> AllPrefixes_Execute() {
            return new StringChallenge().AllPrefixes(CodeVariable.PrefixLength, CodeVariable.Words);
        }
        
        public void FindPalindromeInString_Execute(string str) {
            new PalindromeChallenge().FindPalindromeInString( !(string.IsNullOrEmpty(str)) ? str : (CodeVariable.Palindrome));
        }

        public void CountNumbers_Execute() {
            var counter = new LinqChallenges().CountNumbers(CodeVariable.CountNumbers, 4 );
            Console.WriteLine(counter);
        }

        public void GetEvenNumbersFromList_Execute() {
            int[] test = [10,0,1];
            Console.WriteLine($"{test.StructMathExtension()}");
            new LinqChallenges().GetEvenNumbersFromList(CodeVariable.CountNumbers );
        }
    }

    public static class CodeVariable {
        public static readonly int PrefixLength = 3;
        public static readonly IEnumerable<string> Words = ["flow", "flea", "Feast", "fast", "Float", "FARTHER", "Father", "fatTER"];

        public static readonly string Palindrome = "RACecar";

        public static readonly int[] CountNumbers = [1,2,3,4,5,6,7,8,9,10];
    }
}