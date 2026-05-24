using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person4
    {
        private string name = string.Empty;
        private int age;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public Person4(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public Person4(string name)
        {
            SetName(name);
            SetAge(0);
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("***************Person Details**********************");
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine("*****************************************************");
        }
    }

    internal class Employee4 : Person4
    {
        protected int employeeId;
        protected string department = string.Empty;

        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(int value)
        {
            employeeId = value;
        }

        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string value)
        {
            department = value;
        }

        public Employee4(string name, int age, int employeeId, string department) : base(name, age)
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        public Employee4(string name, int employeeId, string department) : base(name)
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        public Employee4(int employeeId, string department) : base("Not Assigned")
        {
            SetEmployeeId(employeeId);
            SetDepartment(department);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("***************Employee Details**********************");
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Employee ID: {GetEmployeeId()}");
            Console.WriteLine($"Department: {GetDepartment()}");
            Console.WriteLine("*****************************************************");
        }

        public void DisplayDetailsWithBase()
        {
            Console.WriteLine("***************Employee Details (with Base Call)****");
            base.DisplayDetails();
            Console.WriteLine($"Employee ID: {GetEmployeeId()}");
            Console.WriteLine($"Department: {GetDepartment()}");
            Console.WriteLine("*****************************************************");
        }
    }
}
