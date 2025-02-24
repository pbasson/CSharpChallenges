using System.Runtime.InteropServices;
using CSharpChallenges.Infrastructure.Enums;
using CSharpChallenges.Infrastructure.Interfaces;

namespace CSharpChallenges.Infrastructure.CodeChallenges
{
    public class StringChallenge : IStringChallenge
    {
        public List<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            // filtered List to get the 
            List<string> newOut = [];

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
            var unionAry = names1.Union(names2).Order().ToArray();
            return unionAry;
        }

        public string WordSplit(string[] strAry)
        {
            try {
                var result = "";
                var getList = strAry[1].Split(',');

                foreach (var item in getList)
                {
                    if (strAry[0].Contains(item) && item.Length > 1) {
                        Console.WriteLine($"Word: {item} ");
                        
                        var getString = strAry[0].Split(item, StringSplitOptions.RemoveEmptyEntries);

                        var checkString = $"{item}{getString[0]}";
                        var checkString02 = $"{getString[0]}{item}";
                        
                        if( checkString == strAry[0]) {
                            result = $"{item},{getString[0]}";
                        }
                        else if( checkString02 == strAry[0]) {
                            result = $"{getString[0]},{item}";
                        }
                        else {
                            return "No Combine Found";
                        }
                    
                    }
                }

                return result;
            }
            catch (Exception) {
                
                throw;
            }
        }
    }

}