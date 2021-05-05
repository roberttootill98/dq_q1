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
            Console.WriteLine(IsPalindrome("Deleveled"));
            // even number of characters
            Console.WriteLine(IsPalindrome("AbBa"));
            // first half upper-case
            Console.WriteLine(IsPalindrome("RACEcar"));
            // not a palindrome
            Console.WriteLine(IsPalindrome("notAPalindrome"));

            /*
            // question two
            // two valid pairs - so four instances
            //Console.WriteLine(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 12));
            Q2_printOut(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 12));
            // no valid pairs - no instances
            //Console.WriteLine(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 36));
            Q2_printOut(FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 36));
            */

            /*
            // question three
            // should get 4576.58 according to my calculations
            Console.WriteLine(GetCarValue(6504.15, 54, 988, 1, 4));
            */
        }

        /**
         * checks if a given string is a palindrome, case insensitive
         * @param {string} input - string that may be a palindrome
         * @returns {bool} true if palindrome
         */
        public static bool IsPalindrome(string input)
        {
            int length = input.Length / 2;
            if(input.Length % 2 != 0)
            {
                length++;
            }

            for(int i = 0; i < length; i++)
            {
                // check if characters match
                if(Char.ToLower(input[i]) != Char.ToLower(input[input.Length - i - 1])) {
                    return false;
                }
            }

            return true;
        }

        /**
         * Finds pairs of integers from a given list l that when summed together result in given sum
         * @param {List<int>} l - list of integers 
         * @param {int} sum - value summed for
         * @returns {List<(int, int)>} tuples of indicies of list or null if there are no instances
         */
        public static List<(int, int)>? FindTwoSum(List<int> l, int sum)
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

            if(pairs.Count == 0)
            {
                return null;
            }
            else
            {
                return pairs;
            }
        }

        /**
         * prints out output of question two
         * @param {List<(int, int>}? l - list of tuples of indicies to be printed out, if null then print out null
         */
        public static void Q2_printOut(List<(int, int)>? l)
        {
            if (l == null)
            {
                Console.WriteLine("null");
                return;
            }
            foreach ((int, int) pair in l)
            {
                Console.WriteLine(pair.Item1 + ", " + pair.Item2);
            }
        }

        /**
         * @param {double} value - purchase value of the car
         * @param {int} age - of the car in months (Given the number of months of how old the car is, reduce its value by fifty percent. After 10 years, its value cannot be reduced further by age. This is not cumulative.)
         * @param {int} miles - number of miles on the car (For every 1,000 miles on the car, reduce its value by one-fifth of a percent. Do not consider remaining miles. After 150,000 miles, its value cannot be reduced further by miles.)
         * @param {int} previousOwner - number of previous owners (If the car has had more than two previous owners, reduce its value by twenty-five percent. If the car has had no previous owners, add ten percent of the FINAL car value at the end.)
         * @param {int} collision - number of collisions the car has been in (For every reported collision the car has been in, remove two percent of its value up to five collisions.)
         * @returns {double} value of car, rounded to two decimals
         */
        public static double GetCarValue(double value, int age, int miles, int previousOwner, int collision)
        {
            if(age > 120)
            {
                age = 120;
            }
            value *= Math.Pow(0.995, age);

            if(miles > 150000)
            {
                miles = 150000;
            }
            // use built in integer division
            value *= Math.Pow(0.998, miles / 1000);

            if(previousOwner > 2)
            {
                value *= 0.75;
            }

            if(collision > 5)
            {
                collision = 5;
            }
            value *= Math.Pow(0.98, collision);

            if(previousOwner == 0)
            {
                value *= 1.1;
            }

            return Math.Round(value, 2);
        }
    }
}
