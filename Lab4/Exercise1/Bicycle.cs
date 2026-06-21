using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Bicycle : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is pedaling");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle has stopped");
        }
    }
}
