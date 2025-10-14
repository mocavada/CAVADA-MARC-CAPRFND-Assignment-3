using System;

namespace Assignments
{
    public class Q3_ArrayCompare
    {
        public static void Run()
        {
            int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int[] array2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

            bool result = (array1[0] == array2[0]) || (array1[^1] == array2[^1]);
            Console.WriteLine(result);
        }
    }
}