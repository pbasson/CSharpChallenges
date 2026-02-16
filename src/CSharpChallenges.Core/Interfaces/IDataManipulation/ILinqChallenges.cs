namespace CSharpChallenges.Core.Interfaces.IDataManipulation;
 
public interface ILinqChallenges {
    /// <summary> Sorted Search:  </summary>
    int CountNumbers(int[] sortedArray, int lessThan);
    void GetEvenNumbersFromList(int[] evenList);
}