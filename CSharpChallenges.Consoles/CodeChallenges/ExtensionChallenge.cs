namespace CSharpChallenges.Consoles.CodeChallenges {
    public static class ExtensionChallenge {
        
        public static int IntegerExtension(this string str) {
            return Int32.Parse(str);
        }

        public static double StructMathExtension(this int[] ints) {
            return Math.Log10(ints[0]); 
        }
    }
}