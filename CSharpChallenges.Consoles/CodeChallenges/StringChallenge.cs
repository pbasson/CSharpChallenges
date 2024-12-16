namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class StringChallenge
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
    }

}