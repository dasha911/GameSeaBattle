using System;
using System.Collections.Generic;
using Coords;

namespace BaseShips
{
    public abstract class BaseShip
    {
        private List<Coords.Coord> listCoord;
        private string name;
        protected string shipType;
        public string Name { get; set; }

        public BaseShip(string name)
        {
            listCoord = new List<Coords.Coord>();
            this.name = name;
        }
        public string ShipType
        {
            get { return shipType; }
            set { name = value; }
        }
        public int length { get; set; }
        abstract public void showShip();
        public BaseShip addCoord(Coords.Coord coordinate)
        { 
            this.listCoord.Add(coordinate);
            return this;
        }
        public List<Coords.Coord> GetCoords()
        { return this.listCoord; }

        public bool isHit(Coords.Coord coordinate)
        {
            foreach (Coords.Coord item in this.listCoord)
            {
                if (item.X == coordinate.X && item.Y == coordinate.Y)
                {
                    return true; //влучання
                }
            }
            return false;
        }

    }
}


