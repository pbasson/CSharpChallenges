namespace CSharpChallenges.Consoles.CodeChallenges
{
    public class LinqChallenges {
        public int CountNumbers(int[] sortedArray, int lessThan)
        {
            int counter = 0;
            // var getList = sortedArray.Where(x => x < (lessThan+1) ).Distinct().Order().ToArray();
            var getList = sortedArray.Where(x => x < (lessThan+1) ).Distinct().Order().Count();
            // Console.WriteLine(getList);
            
            for (int i = 0; i < sortedArray.Count(); i++)
            {
                if(sortedArray[i] < lessThan) {
                    counter++;
                }  
                else {
                    break;
                }
                
            }   
            return counter;
        }

    }


}