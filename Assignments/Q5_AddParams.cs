using System;

namespace Assignments
{
    public class Q5_AddParams
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public static void Run()
        {
            Console.WriteLine(Add(1, 2, 3, 4)); // Output: 10
            Console.WriteLine(Add(5, 10));      // Output: 15
        }
    }
}