using CSharpChallenges.Infrastructure.Interfaces;

namespace CSharpChallenges.Infrastructure.CodeChallenges
{
    public class LinqChallenges : ILinqChallenges {
        public int CountNumbers(int[] sortedArray, int lessThan)
        {
            int counter = 0;
            var getList = sortedArray.Where(x => x < (lessThan+1) ).Distinct().Order().Count();
            
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

        public void GetEvenNumbersFromList(int[] evenList) {
            
            var getList = evenList.Where(x => x % 2 == 0 ).ToArray();

            var getList1 = from even in evenList
                        where even % 2 == 0 
                        select even; 

            for (int i = 0; i < getList.Count(); i++) {
                Console.WriteLine( $"{getList[i]}" );
            }
            getList.ToList().ForEach(action => {
                Console.WriteLine( $"{action}" ); 
            } );            
            
            foreach (var item in getList1) {
                Console.WriteLine( $"{item}" );
            }

        }
    }


}