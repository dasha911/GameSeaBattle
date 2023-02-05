using System;
using BaseShips;


namespace TypeCruiser
{
    class Cruiser : BaseShip
    {
        public Cruiser(string name) : base(name)
        {
            ShipType = "Cruiser";
            length = 3;
        }
        public override void showShip()
        {
            Console.WriteLine(shipType);
        }
    }
}


