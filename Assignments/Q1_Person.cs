using System;

namespace CAVADA_MARC_CAPRFND_Assignment_2.Assignments
{
    // Base class Person
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }

    // Derived class Student
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }

    // Derived class Teacher
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }
}