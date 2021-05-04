using System;
using System.Collections.Generic;

namespace DQ_questions
{
    class DQ_questions
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
            // not a palindrome
            Console.WriteLine(isPalindrome("notAPalindrome"));

            // question two
            // two valid pairs - so four instances
            q2_printOut(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 12));
            // no valid pairs - no instances
            q2_printOut(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 36));

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

        public static List<(int, int)> FindTwoSum(List<int> l, int sum)
        {
            List<(int, int)> pairs = new List<(int, int)> { };

            for(int i = 0; i < l.Count; i++)
            {
                for(int j = 0; j < l.Count; j++)
                {
                    // skip same index
                    if (i == j)
                    {
                        continue;
                    }

                    // check for sum
                    if(l[i] + l[j] == sum)
                    {
                        pairs.Add((l[i], l[j]));
                    }
                }
            }

            return pairs;
        }

        /**
         * prints out output of question two
         */
        public static void q2_printOut(List<(int, int)> l)
        {
            foreach ((int, int) pair in l)
            {
                Console.WriteLine(pair.Item1 + ", " + pair.Item2);
            }
        }
    }
}
