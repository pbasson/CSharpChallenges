namespace CSharpChallenges.Core.CodeConcepts.MathematicalProblems; 

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
        var original = (b*b) - (4*a*c);

        var plus = (-b + Math.Sqrt(original))/(2*a); 
        var neg = (-b - Math.Sqrt(original))/(2*a); 
        
        return new Tuple<double, double>(plus,neg); 
    }

    public int BracketCombinations(int num) {
        if (num <= 1) { return 1; }
        
        int res = 0; 

        for (int i = 0; i < num; i++) {
            res += BracketCombinations(i) * BracketCombinations(num - (i + 1) ); 
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
