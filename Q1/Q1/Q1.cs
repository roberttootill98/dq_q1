using System;

namespace Q1
{
    class Q1
    {
        static void Main(string[] args)
        {
            // question one

            // odd number of characters
            Console.WriteLine(isPalindrome("Deleveled"));

            // even number of characters
            Console.WriteLine(isPalindrome("AbBa"));

            // first half upper-case
            Console.WriteLine(isPalindrome("RACEcar"));
        }

        public static bool isPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                // check is characters match
                if(Char.ToLower(input[i]) != Char.ToLower(input[input.Length - i - 1])) {
                    return false;
                }
            }

            return true;
        }
    }
}
