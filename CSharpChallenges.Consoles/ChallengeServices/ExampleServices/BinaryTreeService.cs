using CSharpChallenges.Infrastructure.ExampleChallenges;

namespace CSharpChallenges.Consoles.ChallengeServices.ExampleServices
{
    public class BinaryTreeService
    {
        public void CountNumbers_Execute()
        {
            Console.WriteLine("START SCRIPT: CountNumbers");
            var StringList = new string[] {"(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)"};
            var counter = new BinarySearchTree().TreeConstructor(StringList);
            Console.WriteLine(counter);
            Console.WriteLine("END SCRIPT");
        }
    }    
}