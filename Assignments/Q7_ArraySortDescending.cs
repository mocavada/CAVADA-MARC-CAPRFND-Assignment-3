using System;

namespace Assignments
{
    public class Q7_ArraySortDescending
    {
        public static void Run()
        {
            int[] array = { 5, 9, 1 };
            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Array in descending order:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}