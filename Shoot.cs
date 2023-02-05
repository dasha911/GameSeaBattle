using System;
using Coords;

namespace Shooting
{
    class Shoot
    {
        private Coords.Coord coordinate;
        private bool hasHit;

        public Shoot(Coords.Coord coordinate, bool hasHit)
        {
            this.coordinate = coordinate;
            this.hasHit = HasHit;
        }

        public Coords.Coord Coord { get; }
        public bool HasHit { get; }

    }
}


