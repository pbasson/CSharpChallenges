using CSharpChallenges.Infrastructure.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ChallengeServices.CodeServices
{
    public class LinqService
    {
        public void CountNumbers_Execute()
        {
            Console.WriteLine("START SCRIPT: CountNumbers");
            var counter = new LinqChallenges().CountNumbers(CodeArray.CountNumbers, 4);
            Console.WriteLine(counter);
            Console.WriteLine("END SCRIPT");
        }


        public void GetEvenNumbersFromList_Execute()
        {
            Console.WriteLine("START: GetEvenNumbersFromList");
            new LinqChallenges().GetEvenNumbersFromList(CodeArray.CountNumbers);
            Console.WriteLine("END SCRIPT");
        }
    }
}