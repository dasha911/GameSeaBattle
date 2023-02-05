using System;
using System.Collections.Generic;
using BaseShips;
using Coords;
using Shooting;



namespace PrintFields
{
    public void printLeftField(List<BaseShip> shipList)
    {
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (j == 0 && i == 0)
                {
                    Console.Write("  ");
                }
                else if (i == 0 && j != 0)
                {
                    Console.Write((j - 1) + "|");
                }

                if (i != 0 && j == 0)
                {
                    Console.Write((i - 1) + "|");
                }

                foreach (BaseShip ship in shipList)
                {
                    foreach (Coord coord in ship.GetCoords())
                    {
                        if (coord.X == i - 1 && coord.Y == j - 1)
                        {
                            Console.Write("1"); // корабель
                        }
                    }
                }

            }

            Console.WriteLine();
        }
    }

    public void printRightField(List<Shoot> shootList)
    {
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (j == 0 && i == 0)
                {
                    Console.Write("  ");
                }
                else if (i == 0 && j != 0)
                {
                    Console.Write((j - 1) + "|");
                }

                if (i != 0 && j == 0)
                {
                    Console.Write((i - 1) + "|");
                }

                foreach (Shoot shoot in shootList)
                {
                    if ((shoot.Coord.X == i - 1 && shoot.Coord.Y == j - 1) && shoot.HasHit == true)
                    {
                        Console.Write("*"); //влучання
                    }
                    else
                    {
                        Console.Write("o"); //промах
                    }
                }

            }

            Console.WriteLine();
        }
    }

}
        
       
