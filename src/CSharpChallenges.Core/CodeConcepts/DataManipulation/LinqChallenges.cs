namespace CSharpChallenges.Core.CodeConcepts.DataManipulation; 

public class LinqChallenges {
    public int CountNumbers(int[] sortedArray, int lessThan) {
        int counter = 0;
        Func<int, bool> IsLess = x => x < (lessThan+1) ; 
        Func<int, bool> IsLessThan = x => x < lessThan; 

        var getList = sortedArray.Where( IsLess ).Distinct().Order().Count();
        
        for (int i = 0; i < sortedArray.Count(); i++)
        {
            if( IsLessThan(sortedArray[i]) ) {
                counter++;
            }  
            else {
                break;
            }
        }   
        return counter;
    }

    public void GetEvenNumbersFromList(int[] evenList) {

        static bool IsLinq(int x) => x % 2 == 0;
        var getList = evenList.Where(IsLinq ).ToArray();

        getList.ToList().ForEach(action => {
            Console.WriteLine( $"{action}" ); 
        } );            

    }
}