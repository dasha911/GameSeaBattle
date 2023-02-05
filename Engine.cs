using System;
using System.Collections.Generic;
using BaseShips;
using Shooting;
using Coords;
using TypeDestroyer;
using TypeCarrier;
using TypeCruiser;
using TypeUnderwater;
using PrintFields;

namespace Enginee
{
    class Engine
    {
        public enum Direction { East, West, North, South };

        private List<BaseShip> shipListPlayer; //гравець
        private List<Shoot> shootListPlayer; //гравець

        private List<BaseShip> shipListRival; //суперник
        private List<Shoot> shootListRival; //суперник

        private Print print;
        private Random random;

        public Engine()
        {
            this.shipListPlayer = new List<BaseShip>();
            this.shootListPlayer = new List<Shoot>();
            this.shipListRival = new List<BaseShip>();
            this.shootListRival = new List<Shoot>();

            print = new Print();
            random = new Random();
        }

        private Coord MoveShip(Direction direction, Coord firstCoord)
        {
            switch (direction)
            {
                case Direction.East:
                    {
                        firstCoord.X += 1;
                    }
                    break;
                case Direction.West:
                {
                        firstCoord.X -= 1;
                    }
                    break;
                case Direction.North:
                    {
                        firstCoord.Y += 1;
                    }
                    break;
                case Direction.South:
                    {
                        firstCoord.Y -= 1;
                    }
                    break;
            }
            return firstCoord;

        }
        public void addShipPlayer(BaseShip baseShip)
        { this.shipListPlayer.Add(baseShip); }

        public void addShootPlayer(Shoot shoot)
        { this.shootListPlayer.Add(shoot); }
        public void addShipRival(BaseShip baseShip)
        { this.shipListRival.Add(baseShip); }
        public void addShootRival(Shoot shoot)
        { this.shootListRival.Add(shoot); }

        public void printFields()
        {
            this.print.printLeftField(this.shipListPlayer);
            this.print.printRightField(this.shootListPlayer);
        }

        private bool checkShipPosition(Coord firstCoord, int shipType, Direction direction, List<BaseShip>list)
        {
            if (shipType == 1) //для 1-палуб 
            {
                foreach (BaseShip item in list)
                {
                    foreach (Coord coord in item.GetCoords())
                    {
                        if (coord.X == firstCoord.X && coord.Y == firstCoord.Y)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void generateShipPlayer()
        {
            BaseShip baseShip = null;
            bool isEmpty = true;
            Direction direction = (Direction)random.Next(0, 4);
            Coord firstCoord = new Coord(this.random.Next(0, 10), this.random.Next(0, 10));
            do
            {

            } while (!isEmpty);
        }
    }
}


