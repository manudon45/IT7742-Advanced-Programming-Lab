using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person5
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public Person5(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person5(string name)
        {
            Name = name;
            Age = 0;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("***************Person Details**********************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("*****************************************************");
        }
    }

    internal class Employee5 : Person5
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; } = string.Empty;

        public Employee5(string name, int age, int employeeId, string department) : base(name, age)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public Employee5(string name, int employeeId, string department) : base(name)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public Employee5(int employeeId, string department) : base("Not Assigned")
        {
            EmployeeId = employeeId;
            Department = department;
        }

        // Override the virtual DisplayDetails method
        public override void DisplayDetails()
        {
            Console.WriteLine("***************Employee Details**********************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine("*****************************************************");
        }
    }

    internal class Manager5 : Employee5
    {
        public int TeamSize { get; set; }

        public Manager5(string name, int age, int employeeId, string department, int teamSize) : base(name, age, employeeId, department)
        {
            TeamSize = teamSize;
        }

        public Manager5(string name, int employeeId, string department, int teamSize)
            : base(name, employeeId, department)
        {
            TeamSize = teamSize;
        }

        public Manager5(int employeeId, string department, int teamSize)
            : base(employeeId, department)
        {
            TeamSize = teamSize;
        }

        // Override the DisplayDetails method to include TeamSize
        public override void DisplayDetails()
        {
            Console.WriteLine("***************Manager Details**********************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Team Size: {TeamSize}");
            Console.WriteLine("*****************************************************");
        }
    }
}
