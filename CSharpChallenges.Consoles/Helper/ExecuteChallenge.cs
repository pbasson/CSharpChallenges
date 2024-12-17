using CSharpChallenges.Consoles.CodeChallenges;

namespace CSharpChallenges.Consoles.Helper
{
    public class ExecuteChallenge
    {

        public ExecuteChallenge()
        {
            // var test = Console.ReadLine();
            // GetEvenNumbersFromList_Execute();
            // ModifyString_Execute();
            GetSubString_Execute();

        }

        public List<string> AllPrefixes_Execute()
        {
            return new StringChallenge().AllPrefixes(CodeVariable.PrefixLength, CodeArray.Words);
        }

        public string ModifyString_Execute()
        {
            return new StringChallenge().ModifyString(CodeVariable.ModString, ModifyStringOptions.Alphabet);
        }

        public void FindPalindromeInString_Execute(string str)
        {
            new PalindromeChallenge().FindPalindromeInString(!string.IsNullOrEmpty(str) ? str : CodeVariable.Palindrome);
        }

        public void CountNumbers_Execute()
        {
            var counter = new LinqChallenges().CountNumbers(CodeArray.CountNumbers, 4);
            Console.WriteLine(counter);
        }

        public string GetSubString_Execute()
        {
            return new StringChallenge().GetSubString(CodeVariable.ModString, 10, 4);
        }

        public void GetEvenNumbersFromList_Execute()
        {

            new LinqChallenges().GetEvenNumbersFromList(CodeArray.CountNumbers);
        }
    }

}