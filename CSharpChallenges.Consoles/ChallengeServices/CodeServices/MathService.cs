using CSharpChallenges.Infrastructure.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ChallengeServices.CodeServices
{
    public class MathService
    {
        public void FindRoots()
        {
            try
            {
                var test = new MathChallenge().FindRoots(CodeArray.Roots[0], CodeArray.Roots[1], CodeArray.Roots[2]);
                Console.WriteLine($"{test.ToString()}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BracketCombinations()
        {
            try
            {
                var input = 3;
                var result = new MathChallenge().BracketCombinations(input);
                Console.WriteLine($"BracketCombinations: {input} / {result}");
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void QuestionsMarks()
        {
            try
            {
                // var input = "acc?7??sss?3rr1??????5";
                var input = "aa6?9";
                var result = new MathChallenge().QuestionsMarks(input);
                Console.WriteLine($"BracketCombinations: {input} / {result}");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}