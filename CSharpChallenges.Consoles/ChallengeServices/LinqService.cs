using CSharpChallenges.Consoles.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ExecuteChallenges
{
    public class LinqService
    {
        public void CountNumbers_Execute()
        {
            var counter = new LinqChallenges().CountNumbers(CodeArray.CountNumbers, 4);
            Console.WriteLine(counter);
        }


        public void GetEvenNumbersFromList_Execute()
        {

            new LinqChallenges().GetEvenNumbersFromList(CodeArray.CountNumbers);
        }
    }
}