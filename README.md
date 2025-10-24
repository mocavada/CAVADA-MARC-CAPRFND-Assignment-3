

# PROGRAMMING TECHNIQUES – Assignment 3  
**CAVADA-MARC-PROJECT-CA_PRTQS-A3**  
**GIT:** [https://github.com/mocavada/CAVADA-MARC-CAPRFND-Assignment-3](https://github.com/mocavada/CAVADA-MARC-CAPRFND-Assignment-3)

---

## 📘 Introduction  
This project is part of the *Programming Techniques – C#* coursework. It focuses on applying **Object-Oriented Programming** principles such as **inheritance**, **encapsulation**, and **method overriding** to simulate a simple scenario distinguishing between a `Teacher` and `Student` using a console-based C# application.

The program prompts the user to enter three names — one teacher and two students. Based on the input, it dynamically creates objects of `Teacher` and `Student` types, each inheriting from a base class `Person`.  

The output demonstrates polymorphic behavior through specific methods:
- The **Teacher** executes the `Explain()` method.  
- Each **Student** executes the `Study()` method.  

This assignment demonstrates foundational C# concepts essential for professional development practices.

---

## 🧩 Code Implementation

### **Program.cs**
```csharp
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


⸻

Q1_Car.cs (Assignment Class File Example)

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


⸻


This version:
- Uses `#` and `##` headings for clear structure.
- Keeps the code blocks syntax-highlighted for `.NET / C#`.
- Is compatible with **GitHub MD**, **Next.js MDX**, or any markdown viewer.

