namespace CSharpChallenges.Consoles.ChallengeServices
{
    public class ExecuteService
    {
        public ExecuteService()
        {
            // new MathService().FindRoots();
            new LinqService().CountNumbers_Execute();
            new LinqService().GetEvenNumbersFromList_Execute();
        }

    }
}