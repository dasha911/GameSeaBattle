using System;
using System.Collections.Generic;

namespace Coords
{
    public class Coord // координати
    {
        private const int mapSize = 10;

        private int x;
        private int y;

        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 

    }
}


