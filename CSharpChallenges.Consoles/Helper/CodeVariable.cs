namespace CSharpChallenges.Consoles.Helper {
    public static class CodeVariable {
        public static readonly int PrefixLength = 3;
        public static readonly string Palindrome = "RACecar";
        public static readonly string ModString = "ga3s54fg4tb54t34asv34";
    }

    public static class CodeArray{
        public static readonly IEnumerable<string> Words = ["flow", "flea", "Feast", "fast", "Float", "FARTHER", "Father", "fatTER"];
        public static readonly int[] CountNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        public static readonly string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        public static readonly string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        public static readonly int[] Roots = [2, 10, 8];

    }

    public enum ModifyStringOptions {
        Alphabet = 0,
        Digits = 1,
        AlphabetDigits = 2,
    }

    public enum DiscountType
    {
        Standard,
        Seasonal,
        Weight
    }
}