using System;
using Assignments;

class Program
{
    static void Main()
    {
        Console.WriteLine("Assignment 2 - Q1: Car Class");
        Car car = new Car();
        car.Start();

        Console.WriteLine("\nAssignment 2 - Q2: Employee Struct");
        Q2_EmployeeProgram.Run();

        Console.WriteLine("\nAssignment 2 - Q3: Array Element Comparison");
        Q3_ArrayCompare.Run();

        Console.WriteLine("\nAssignment 2 - Q4: Palindrome Check");
        Q4_Palindrome.Run();

        Console.WriteLine("\nAssignment 2 - Q5: Params Sum");
        Q5_AddParams.Run();

        Console.WriteLine("\nAssignment 2 - Q6: Array Copy");
        Q6_ArrayCopy.Run();

        Console.WriteLine("\nAssignment 2 - Q7: Array Sorting Descending");
        Q7_ArraySortDescending.Run();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}