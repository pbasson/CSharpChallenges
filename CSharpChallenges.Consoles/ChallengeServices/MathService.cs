using CSharpChallenges.Infrastructure.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ChallengeServices
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
    }
}