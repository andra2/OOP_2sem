using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Unit
    {
        private static int count = 0;
        private static Random random = new Random();
        public int Health;
        public string Name { get; set; }
        public Unit()
        {
            Name = $"Unit {count++}";
            Health = random.Next(100, 300);
        }

        public override string ToString()
        {
            return $"{this.Name}, HP: {this.Health}";
        }
    }

    static class UnitCollection
    {
        public static List<Unit> units = new List<Unit>();

        public static void AddUnits(int number)
        {
            for (int i = 0; i < number; i++)
            {
                units.Add(new Unit());
            }
        }

        public static int AscSort(Unit x, Unit y)
        {
            if (x.Health > y.Health)
                return 1;
            if (x.Health == y.Health)
                return 0;
            if (x.Health < y.Health)
                return -1;
            return -1;
        }

        public static int DescSort(Unit x, Unit y)
        {
            if (x.Health > y.Health)
                return -1;
            if (x.Health == y.Health)
                return 0;
            if (x.Health < y.Health)
                return 1;
            return 1;
        }

        public static void Sort(Comparison<Unit> compare) => units.Sort(compare);
        public static List<Unit> GetAboveAvg() => units.Select(x => x).Where(x => x.Health > 150).ToList();
        public static List<Unit> GetBelowAvg() => units.Select(x => x).Where(x => x.Health < 150).ToList();
        public static List<Unit> GetSomething() => units.Select(x => x).Where(x => (x.Health < 130) || (x.Health > 270)).ToList();
    }
}
