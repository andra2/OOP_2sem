using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Memento
    {
        public IUnitState UnitState { get; set; }
        public string Name { get; set; }

        public Memento(IUnitState state, string name)
        {
            UnitState = state;
            Name = name;
        }
    }
}
