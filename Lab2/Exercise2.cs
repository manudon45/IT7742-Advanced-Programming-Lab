using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor with both Name and Age
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Overloaded constructor with only Name
        public Person2(string name)
        {
            Name = name;
            Age = 0; // setting this to defailt to 0
        }
    }

    internal class Employee2 : Person2
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }

        public Employee2(string name, int age, int employeeId, string department) : base(name, age)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public Employee2(string name, int employeeId, string department) : base(name)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public Employee2(int employeeId, string department) : base("Not Assigned")
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("***************Employee Details****************************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine("******************************************************************");
        }
    }
}
