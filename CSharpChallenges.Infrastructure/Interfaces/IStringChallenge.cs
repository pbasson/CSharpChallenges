using CSharpChallenges.Infrastructure.Enums;

namespace CSharpChallenges.Infrastructure.Interfaces
{
    public interface IStringChallenge
    {
        List<string> AllPrefixes(int prefixLength, IEnumerable<string> words);
        string ModifyString(string str, ModifyStringOptions modifyStringOptions);
        string GetSubString(string str, int length, int start = 0 );
        string ReplaceCharInString(string str, int index );
        string[] UniqueNames(string[] names1, string[] names2);

    }
}