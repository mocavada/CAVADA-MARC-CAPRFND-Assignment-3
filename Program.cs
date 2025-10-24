using System;
using CAVADA_MARC_CAPRFND_Assignment_2.Assignments;

namespace CAVADA_MARC_CAPRFND_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three names:");

            // Use null-coalescing operator to avoid nullable warnings
            string name1 = Console.ReadLine() ?? string.Empty;
            string name2 = Console.ReadLine() ?? string.Empty;
            string name3 = Console.ReadLine() ?? string.Empty;

            // Create objects safely with guaranteed non-null strings
            Person[] people = new Person[3];
            people[0] = new Teacher(name1);
            people[1] = new Student(name2);
            people[2] = new Student(name3);

            Console.WriteLine("\nOutput:");
            ((Teacher)people[0]).Explain();
            ((Student)people[1]).Study();
            ((Student)people[2]).Study();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}