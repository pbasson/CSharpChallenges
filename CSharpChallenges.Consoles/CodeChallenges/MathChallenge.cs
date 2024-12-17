using CSharpChallenges.Consoles.Helper;
using CSharpChallenges.Consoles.Interfaces;

namespace CSharpChallenges.Consoles.CodeChallenges {
    public class MathChallenge : IMathChallenge
    {
        public double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType) {
            switch (discountType)
            {
                case DiscountType.Standard:
                    return totalPrice - (totalPrice* 0.06);
                case DiscountType.Seasonal:
                    return totalPrice - (totalPrice* 0.12);
                case DiscountType.Weight:
                    if ((int)cartWeight > 10)
                    {
                        return totalPrice - (totalPrice* 0.18);
                    } 
                    else
                    {
                        return totalPrice - (totalPrice* 0.06);
                    }
                default:
                    return 0.0;
            }
        } 
    }
}