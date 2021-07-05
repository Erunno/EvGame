using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.PrimitiveTypes
{
    public struct MapPoint
    {
        public MapPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { get; }
        public double Y { get; }

        public static MapPoint operator +(MapPoint first, MapPoint second)
            => new MapPoint(first.X + second.X, first.Y + second.Y);

        public static MapPoint operator -(MapPoint first, MapPoint second)
            => new MapPoint(first.X - second.X, first.Y - second.Y);

        public static MapPoint operator -(MapPoint first)
            => new MapPoint(-first.X, -first.Y);

        public static MapPoint operator *(MapPoint pt, double ratio)
            => new MapPoint(pt.X * ratio, pt.Y * ratio);

        public static MapPoint operator *(double ratio, MapPoint pt)
            => new MapPoint(pt.X * ratio, pt.Y * ratio);

    }
}
