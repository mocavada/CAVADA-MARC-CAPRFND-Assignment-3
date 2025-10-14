using System;

namespace Assignments
{
    public struct BirthDate
    {
        public int Day;
        public int Month;
        public int Year;
    }

    public struct Employee
    {
        public string Name;
        public BirthDate DOB;
    }

    public class Q2_EmployeeProgram
    {
        public static void Run()
        {
            Employee[] employees = new Employee[2];

            employees[0].Name = "H. Rana";
            employees[0].DOB.Day = 5;
            employees[0].DOB.Month = 2;
            employees[0].DOB.Year = 58;

            employees[1].Name = "S. Mathur";
            employees[1].DOB.Day = 4;
            employees[1].DOB.Month = 8;
            employees[1].DOB.Year = 59;

            foreach (var emp in employees)
            {
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Birth Date: {emp.DOB.Day}/{emp.DOB.Month}/{emp.DOB.Year}");
                Console.WriteLine();
            }
        }
    }
}
