using System;

namespace Assignments
{
    public class Q6_ArrayCopy
    {
        public static void Run()
        {
            int n = 3;
            int[] array1 = { 15, 10, 12 };
            int[] array2 = new int[n];

            array1.CopyTo(array2, 0);

            Console.WriteLine("Elements in first array:");
            Console.WriteLine(string.Join(" ", array1));

            Console.WriteLine("Elements copied into second array:");
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}