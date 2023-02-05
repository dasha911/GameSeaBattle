using System;
using BaseShips;


namespace TypeCarrier 
{
    class Carrier : BaseShip
    {
        public Carrier(string name) : base(name) 
        {
            ShipType = "Carrier";
            length = 4;
        }
        public override void showShip()
        {
            Console.WriteLine(shipType);
        }        
    }
}


