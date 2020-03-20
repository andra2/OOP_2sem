using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    interface IMoveable
    {
        public void MoveX(int range);
        public void MoveY(int range);
        public void Show();
    }
    class Swordsman
    {
        public void MoveX(IMoveable moveable, int i)
        {
            moveable.MoveX(i);
        }
        public void MoveY(IMoveable moveable, int i)
        {
            moveable.MoveX(i);
        }
        public void Show(IMoveable moveable)
        {
            moveable.Show();
        }
    }
    class Unit : IMoveable
    {
        private int x = 0, y = 0;
        public void MoveX(int range)
        {
            Console.WriteLine("иду");
            x += range;
        }
        public void MoveY(int range)
        {
            Console.WriteLine("иду");
            y += range;
        }
        public void Show()
        {
            Console.WriteLine("координаты обьекта на земле\nX: {0}\nY: {1}\n", x, y);
        }
    }
    class Ship:IComponent
    {
        public string Name { get; set; }

        private int x = 0, y = 0;
        public void MoveX(int range)
        {
            Console.WriteLine("плыву");
            x += range;
        }
        public void MoveY(int range)
        {
            Console.WriteLine("плыву");
            y += range;
        }
        public void Show()
        {
            Console.WriteLine("координаты обьекта на воде\nX: {0}\nY: {1}\n", x, y);
        }
    }
    class ShipToUnitAdapter : IMoveable
    {
        Ship ship;
        public ShipToUnitAdapter(Ship s)
        {
            ship = s;
        }
        public void MoveX(int i)
        {
            ship.MoveX(i);
        }
        public void MoveY(int i)
        {
            ship.MoveY(i);
        }
        public void Show()
        {
            ship.Show();
        }
    }


}
