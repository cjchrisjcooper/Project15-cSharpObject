using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xdiff = X - x;
            int ydiff = Y - y;
            int xSquared = xdiff * xdiff;
            int ySquared = ydiff * ydiff;

            return (int)Math.Sqrt(xSquared + ySquared);
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }



    }
}
