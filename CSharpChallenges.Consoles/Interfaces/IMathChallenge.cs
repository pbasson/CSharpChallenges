using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.Interfaces
{
    public interface IMathChallenge
    {
        double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType);
        Tuple<int, int> FindTwoSum(List<int> list, int sum);
        Tuple<double, double> FindRoots(double a, double b, double c);

    }
}