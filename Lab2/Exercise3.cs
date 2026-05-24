using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person3
    {
        // Private fields
        private string name = string.Empty;
        private int age;

        // Public getter and setter for Name
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        // Public getter and setter for Age
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public Person3(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public Person3(string name)
        {
            SetName(name);
            SetAge(0);
        }
    }

    internal class Employee3 : Person3
    {
        // Protected fields
        protected int employeeId;
        protected string department = string.Empty;

        // Public getter and setter for EmployeeId
        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(int value)
        {
            employeeId = value;
        }

        // Public getter and setter for Department
        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string value)
        {
            department = value;
        }

        public Employee3(string name, int age, int employeeId, string department) : base(name, age)
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        // Constructor with Name, EmployeeId, and Department
        public Employee3(string name, int employeeId, string department) : base(name)
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        // Overloaded constructor with only EmployeeId and Department
        public Employee3(int employeeId, string department) : base("Not Assigned")
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("***************Employee Details**********************");
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Employee ID: {GetEmployeeId()}");
            Console.WriteLine($"Department: {GetDepartment()}");
            Console.WriteLine("*****************************************");
        }
    }
}
