using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    public interface IComponent
    {
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
        public void AddComponent(IComponent component);
    }

    public class Map : IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();
        public string Title { get; set; }
        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }
        public void Draw()
        {
            Console.WriteLine(Title);
            foreach(var component in _map)
            {
                component.Draw();
            }
        }
        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            foreach(var component in _map)
            {
                var found = component.Find(title);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }
    }
}