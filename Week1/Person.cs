using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Age = 30;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
