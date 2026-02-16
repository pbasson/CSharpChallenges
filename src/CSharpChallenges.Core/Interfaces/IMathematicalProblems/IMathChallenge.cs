namespace CSharpChallenges.Core.Interfaces.IMathematicalProblems;

public interface IMathChallenge
{
    /// <summary> Mega Store:  </summary>
    double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType);
    /// <summary> Two Sum:  </summary>
    Tuple<int, int> FindTwoSum(List<int> list, int sum);
    /// <summary> Quadratic Equation:  </summary>
    int BracketCombinations(int num);
    string QuestionsMarks(string str);
}