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
                    if ((int)cartWeight > 10) {
                        return totalPrice - (totalPrice* 0.18);
                    } 
                    else {
                        return totalPrice - (totalPrice* 0.06);
                    }
                default:
                    return 0.0;
            }
        } 

        public Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            var hs = new HashSet<int>(list);

            for (int i = 0; i < list.Count; i++)
            {
                var diff = sum - list[i];
                if (hs.Contains(diff) && i != list.IndexOf(diff))
                    return new Tuple<int, int>(i, list.IndexOf(diff));
            }
            return new Tuple<int, int>(0,0);
        }

        public Tuple<double, double> FindRoots(double a, double b, double c)
        {
            return new Tuple<double, double>(0,0); 
        }
    }
}