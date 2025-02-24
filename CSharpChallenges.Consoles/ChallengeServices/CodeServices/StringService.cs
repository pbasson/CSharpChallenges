using CSharpChallenges.Consoles.Helper;
using CSharpChallenges.Infrastructure.CodeChallenges;
using CSharpChallenges.Infrastructure.Enums;

namespace CSharpChallenges.Consoles.ChallengeServices.CodeServices
{
    public class StringService {
        public List<string> AllPrefixes_Execute() {
            return new StringChallenge().AllPrefixes(CodeVariableStruct.PrefixLength, CodeArray.Words);
        }

        public string ModifyString_Execute() {
            return new StringChallenge().ModifyString(CodeVariableStruct.ModString, ModifyStringOptions.Alphabet);
        }

        public string GetSubString_Execute() {
            return new StringChallenge().GetSubString(CodeVariableStruct.ModString, 10, 4);
        }

        public void ReplaceCharInString() {
            Console.WriteLine("String:{0}", CodeVariableStruct.ModString);
            var result = new StringChallenge().ReplaceCharInString(CodeVariableStruct.ModString, CodeVariableStruct.PrefixLength);
            Console.WriteLine("ReplaceCharInString:{0}", result);
        }

        public void UniqueNames() {
            var result = new StringChallenge().UniqueNames(CodeArray.names1, CodeArray.names2);
            Console.WriteLine("UniqueNames:{0}", string.Join(", ", result));
        }

        public void WordSplit() {
            var result = new StringChallenge().WordSplit(CodeArray.WordAry01);
            Console.WriteLine(result);
        } 
    }

}