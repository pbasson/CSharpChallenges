namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class LinqChallenges {
        public int CountNumbers(int[] sortedArray, int lessThan)
        {
            var test = sortedArray.Where(x => x < (lessThan+1) ).Distinct().Order().ToArray();
            
            Console.WriteLine(test);
            return 0;
        }

    }


}