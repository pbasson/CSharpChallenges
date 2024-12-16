namespace CSharpChallenges.CodeChallenges {
    public class StringCode {
        public List<string> AllPrefixes(int prefixLength, IEnumerable<string> words) {
            // filtered List to get the 
            List<string> newOut = new List<string>();

            foreach (var item in words)
            {
                //Console.WriteLine($"Test-01:{item}");
                newOut.Add(item.Substring(0, prefixLength - 1).ToLower());
            }

            var outString = newOut.Distinct().Order().ToList();
            // var test2 = test1.AsEnumerable();
            Console.WriteLine($"Test-02: {string.Join(", ", outString)}");
            return outString;
        }
    }

    public static class CodeVariable {
        public static readonly int PrefixLength = 4;
        public static readonly IEnumerable<string> Words  = new string[] { "flow", "flea", "Feast", "fast", "Float", "FARTHER", "Father", "fatTER" };


    } 
}