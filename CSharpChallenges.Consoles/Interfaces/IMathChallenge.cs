using CSharpChallenges.Consoles.Helper;

namespace CSharpChallenges.Consoles.Interfaces
{
    public interface IMathChallenge
    {
        double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType);
    }
}