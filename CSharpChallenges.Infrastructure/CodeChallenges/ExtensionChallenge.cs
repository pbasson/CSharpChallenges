namespace CSharpChallenges.Infrastructure.CodeChallenges {
    public static class ExtensionChallenge {
        
        public static int IntegerExtension(this string str) {
            return Int32.Parse(str);
        }

        public static double StructMathExtension(this int[] ints) {
            return Math.Log10(ints[0]); 
        }

        public static double DoubleMathExtension(this double ints) {
            return Math.Log10(ints); 
        }
    }
}