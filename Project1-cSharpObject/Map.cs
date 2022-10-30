using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    public class Map
    {
        public int Width { get; private set; }
        public int Height { get; private set; }


        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X < Width && point.Y < Height &&
                   point.X >= 0 && point.Y >= 0;
        }



    }
}
