using System.Linq;
using CSharpChallenges.Consoles.CodeChallenges;
using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.ExecuteChallenges
{
    public class StringExecute
    {
        public List<string> AllPrefixes_Execute()
        {
            return new StringChallenge().AllPrefixes(CodeVariable.PrefixLength, CodeArray.Words);
        }

        public string ModifyString_Execute()
        {
            return new StringChallenge().ModifyString(CodeVariable.ModString, ModifyStringOptions.Alphabet);
        }

        public string GetSubString_Execute()
        {
            return new StringChallenge().GetSubString(CodeVariable.ModString, 10, 4);
        }

        public void ReplaceCharInString()
        {
            Console.WriteLine("String:{0}", CodeVariable.ModString);
            var test = new StringChallenge().ReplaceCharInString(CodeVariable.ModString, CodeVariable.PrefixLength);
            Console.WriteLine("ReplaceCharInString:{0}", test);
        }

        public void UniqueNames() {
            var test = new StringChallenge().UniqueNames(CodeArray.names1,CodeArray.names2);

            Console.WriteLine("UniqueNames:{0}", string.Join(", ",test));
        }
    }

}