using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Car : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
