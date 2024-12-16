using CSharpChallenges.CodeChallenges;

namespace CSharpChallenges
{
    public static class Program
    {

        public static void Main(string[] str)
        {
            Console.WriteLine(new StringCode().AllPrefixes(CodeVariable.PrefixLength, CodeVariable.Words));
            Console.ReadLine();
        }

    }
}

