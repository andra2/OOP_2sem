using System;
using System.Collections.Generic;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Swordsman man = new Swordsman("артур");
            Swordsman unit = new Swordsman("вася");
            Ship ship = new Ship();
            man.MoveX(unit,10);
            ShipToUnitAdapter s2 = new ShipToUnitAdapter(ship);
            man.MoveX(s2, 10);
            man.Show(s2);
            man.Show(unit);

            Map map = new Map();
            map.AddComponent(man);
            map.AddComponent(unit);
            map.AddComponent(new Swordsman("генрих"));
            map.Find("артур").Draw();
            map.Find("артур").AddComponent(man);

            map.AddComponent(new CoolerMinion("арторий"));
            map.Find("арторий").Draw();
            map.Draw();
        }
    }
}
