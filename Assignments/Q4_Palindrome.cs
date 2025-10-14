using System;

namespace Assignments
{
    public class Q4_Palindrome
    {
        public static void Run()
        {
            string[] testStrings = { "aba", "abcd" };

            foreach (var str in testStrings)
            {
                string reversed = new string(str.ToCharArray().Reverse().ToArray());
                bool isPalindrome = str == reversed;
                Console.WriteLine($"'{str}' -> {isPalindrome}");
            }
        }
    }
}