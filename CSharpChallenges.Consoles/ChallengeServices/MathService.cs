using CSharpChallenges.Consoles.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ExecuteChallenges
{
    public class MathService
    {
        public void FindRoots() {
            var test = new MathChallenge().FindRoots(CodeArray.Roots[0],CodeArray.Roots[1],CodeArray.Roots[2]);
            Console.WriteLine($"{test.ToString()}");
        }    
    }
}