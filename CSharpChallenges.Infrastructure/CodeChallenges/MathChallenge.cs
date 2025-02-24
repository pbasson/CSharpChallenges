using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using CSharpChallenges.Infrastructure.Enums;
using CSharpChallenges.Infrastructure.Interfaces;

namespace CSharpChallenges.Infrastructure.CodeChallenges {
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
            var plus = (-b + Math.Sqrt((b*b) - (4*a*c) ))/(2*a); 
            var neg = (-b - Math.Sqrt((b*b) - (4*a*c) ))/(2*a); 
            
            // Console.WriteLine($"{a},{b},{c}: {neg},{plus} ");
            return new Tuple<double, double>(plus,neg); 
        }

        public int BracketCombinations(int num) {
            int res = 0; 
            // Console.WriteLine($"Num: {num} ");            
            if (num <= 1) { return 1; }

            for (int i = 0; i < num; i++) {
                res += BracketCombinations(i) * BracketCombinations(num - (i + 1) ); 
                // Console.WriteLine($"Num: {num} - Res: {res}");
            } 
            return res; 
        }

        public string QuestionsMarks(string str) { 
            char defChar = 'a';
            string result = "false";
            int counter = 0;
            char prevDigit = defChar;
            char curDigit = defChar;

            for (int i = 0; i < str.Length; i++) {
                char digit = str[i];
                if (digit == '?') { counter++; }
                else if (char.IsDigit(digit)) {
                    if (prevDigit == defChar) { prevDigit = digit; }
                    else if (curDigit == defChar) {
                        curDigit = digit;
                        bool checkValue = (int)char.GetNumericValue(prevDigit) + (int)char.GetNumericValue(curDigit) == 10;
                        bool checkCount = counter == 3;
                        if ( checkValue && checkCount ) {
                            result = "true";
                            prevDigit = curDigit;
                            curDigit = defChar;
                        }
                        else if( checkValue && !checkCount ) {
                            return "false";
                        }
                    }
                    counter = 0;
                }
            }
            return result;
        }
    }
}
