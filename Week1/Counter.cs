using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Counter
    {
        public static int Count = 0;

        public void Increment()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }
    }
}
