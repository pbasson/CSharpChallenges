using CSharpChallenges.Consoles.ChallengeServices.CodeServices;
using CSharpChallenges.Consoles.ChallengeServices.ExampleServices;

namespace CSharpChallenges.Consoles.ChallengeServices
{
    public class ExecuteService
    {
        public ExecuteService()
        {
            new MathService().QuestionsMarks();
            // new MathService().BracketCombinations();
            // new LinqService().CountNumbers_Execute();
            // new LinqService().GetEvenNumbersFromList_Execute();

            // new BinaryTreeService().CountNumbers_Execute();
        }

    }
}