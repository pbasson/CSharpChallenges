using CSharpChallenges.Consoles.Helper;
using CSharpChallenges.Consoles.Interfaces;

namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class StringChallenge : IStringChallenge
    {
        public List<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            // filtered List to get the 
            List<string> newOut = new List<string>();

            foreach (var item in words)
            {
                //Console.WriteLine($"Test-01:{item}");
                newOut.Add(item.Substring(0, prefixLength - 1).ToLower());
            }

            var outString = newOut.Distinct().Order().ToList();
            Console.WriteLine($"OutString: {string.Join(", ", outString)}");
            return outString;
        }


        public string ModifyString(string str, ModifyStringOptions modifyStringOptions) {
            
            switch (modifyStringOptions)
            {
                case ModifyStringOptions.Alphabet: 
                    Console.WriteLine($"String: {str}");

                    var newChar = str.ToLower().Where(x => Char.IsLetter(x) );                
                    Console.WriteLine($"newString: {string.Join("", newChar)}");
                    break;
                default:
                    break;
            }

            return str;
        }

        public string GetSubString(string str, int length, int start = 0 ) {
            // Console.WriteLine($"String: {str}");
            
            var subString = str.Substring(start,length);
            
            // Console.WriteLine($"String: {subString}");
            return subString;
        }

        public string ReplaceCharInString(string str, int index) {
            char[] newChar = str.ToCharArray();

            for (int i = 0; i < newChar.Count(); i++) {
                if ((i+1) % index == 0) {
                    newChar[i] = 'X';
                }
            }

            return new string(newChar.ToArray());
        }

        public string[] UniqueNames(string[] names1, string[] names2)
        {
            var test = names1.Union(names2).Order().ToArray();

            return test;
        }
    }

}