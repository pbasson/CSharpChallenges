using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.Interfaces
{
    public interface IMathChallenge
    {
        /// <summary> Mega Store:  </summary>
        double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType);
        /// <summary> Two Sum:  </summary>
        Tuple<int, int> FindTwoSum(List<int> list, int sum);
        /// <summary> Quadratic Equation:  </summary>
        Tuple<double, double> FindRoots(double a, double b, double c);

    }
}