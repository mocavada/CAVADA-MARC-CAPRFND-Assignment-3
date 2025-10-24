
# PROGRAMMING TECHNIQUES - Assignment 3

**CAVADA-MARC-PROJECT-CA_PRTQS-A3**  
**GIT:** [https://github.com/mocavada/CAVADA-MARC-CAPRFND-Assignment-3](https://github.com/mocavada/CAVADA-MARC-CAPRFND-Assignment-3)

---

## 📘 Introduction
This project demonstrates the application of **Object-Oriented Programming (OOP)** concepts in **C#**, focusing on **inheritance, encapsulation, and polymorphism**.  
It is a simple console-based application that classifies individuals as either **Teacher** or **Students**, executing the appropriate behavior depending on their role.  

Developed under the **.NET 9.0 Console App** structure, this assignment is part of *Programming Techniques - C#* coursework.

---

## 🧠 Objective
To build a C# console program that:
- Accepts three names from the user.
- Identifies one as a **Teacher** and two as **Students**.
- Calls each appropriate method:
  - `Teacher.Explain()` → outputs **“Explain”**
  - `Student.Study()` → outputs **“Study”**

---

## 🧩 Specifications
- Define a **base class** `Person` with:
  - A `Name` property
  - A constructor accepting the name
  - A `ToString()` override to display the name

- Create two **derived classes**:
  - `Student` with a `Study()` method
  - `Teacher` with an `Explain()` method

- Store all instances in a `Person[]` array.
- Use `Console.ReadLine()` for input and **property syntax** for all class properties.

---

## 🖥️ Sample Execution

**Input:**

Juan
Sara
Carlos

**Output:**

Explain
Study
Study

---

## ⚙️ How to Run
1. Open the terminal inside the project folder.  
2. Run:
   ```bash
   dotnet build
   dotnet run

	3.	Enter three names when prompted.

⸻

🧾 Files Structure

CAVADA-MARC-CAPRFND-Assignment-3
├── Assignments
│   ├── Q1_Person.cs
│   ├── Q2_Employee.cs
│   ├── Q3_ArrayCompare.cs
│   ├── Q4_Palindrome.cs
│   ├── Q5_AddParams.cs
│   ├── Q6_ArrayCopy.cs
│   └── Q7_ArraySortDescending.cs
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
└── README.md


⸻

🧮 Source Code

Program.cs

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

Assignments/Q1_Person.cs

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

📄 End of Assignment 3 Documentation

---
