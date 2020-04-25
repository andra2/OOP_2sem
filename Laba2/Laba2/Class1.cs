using System;
using System.Collections.Generic;

namespace Laba2
{
    interface IMoveable
    {
        public void MoveX(int range);
        public void MoveY(int range);
        public void Show();
    }
    class Swordsman: Unit, IComponent
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
        public Swordsman(string name) : base(name) { }
    }
    abstract class Unit : IMoveable, IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }
        public string Title { get; set; }
        private int x = 0, y = 0;
        public virtual void Draw()
        {
            Console.WriteLine(Title);
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
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
        public Unit(string name)
        {
            Title = name;
        }
    }
    class Ship:IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }
        public string Title { get; set; }

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
        public void Draw()
        {
            Console.WriteLine("координаты обьекта на воде\nX: {0}\nY: {1}\n", x, y);
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
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
            ship.Draw();
        }
    }


}
