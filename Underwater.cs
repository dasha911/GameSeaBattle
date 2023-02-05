using System;
using BaseShips;

namespace TypeUnderwater
{
    class Underwater : BaseShip
    {
        public Underwater(string name) : base(name)
        {
            ShipType = "Underwater";
            length = 1;
        }
        public override void showShip()
        {
            Console.WriteLine(shipType);
        }
    }
}


