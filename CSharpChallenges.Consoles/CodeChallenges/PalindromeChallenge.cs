namespace CSharpChallenges.Consoles.CodeChallenges {
    public class PalindromeChallenge {
        // <summary> Find Palindrome in String. Will only contain Alphabet from this it is will identified if string is a Palindrome </summary>
        public void FindPalindromeInString(string str) {

            if (string.IsNullOrEmpty(str) ) { Console.WriteLine("String is not Valid/Empty"); }
            else {
                string result = new string(str.Where(ch => char.IsLetter(ch)).ToArray()).ToLower();

                if (result.Length < 3) { Console.WriteLine("String is not Valid"); }
                else {
                    int len = result.Length;
                    bool isPalindrome = true;

                    for (int i = 0; i < len / 2; i++) {
                        if (result[i] != result[len - 1 - i]) {
                            isPalindrome = false;
                            break;
                        }
                    }
                    Console.WriteLine(isPalindrome ? $"{result} is a palindrome." : $"{result} it's not a palindrome.");
                }
            }
        }
    }
}
