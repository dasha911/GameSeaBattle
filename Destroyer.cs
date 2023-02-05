using System;
using BaseShips;

namespace TypeDestroyer
{
    class Destroyer : BaseShip
    {
        public Destroyer(string name) : base(name)
        {
            ShipType = "Destroyer";
            length = 2;
        }
        public override void showShip()
        {
            Console.WriteLine(shipType);
        }
    }
}


