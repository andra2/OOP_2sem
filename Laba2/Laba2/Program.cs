using System;
using System.Collections.Generic;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Swordsman man = new Swordsman();
            Unit unit = new Unit();
            Ship ship = new Ship();
            man.MoveX(unit,10);
            ShipToUnitAdapter s2 = new ShipToUnitAdapter(ship);
            man.MoveX(s2, 10);
            man.Show(s2);
            man.Show(unit);
        }
    }
}
