using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }
    }

    internal class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, int employeeId, string department) : base(name, age)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public Employee(int employeeId, string department) : base("Not Assigned fr now")
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("***************Employee Details**********************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine("******************************************************************");
        }
    }
}
