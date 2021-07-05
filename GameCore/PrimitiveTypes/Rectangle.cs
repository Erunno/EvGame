using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.PrimitiveTypes
{
    public struct Rectangle
    {
        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public double X { get; }
        public double Y { get; }
        public double Width { get; }
        public double Height { get; }

        public static explicit operator Rectangle((double, double, double, double) d)
            =>  new Rectangle(d.Item1, d.Item2, d.Item3, d.Item4 );
    }
}
