using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get { return Width * Height; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
