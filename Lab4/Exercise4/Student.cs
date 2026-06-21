using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name} ({Course})";
        }
    }
}
