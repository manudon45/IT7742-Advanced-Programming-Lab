using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
