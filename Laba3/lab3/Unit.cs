using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Unit
    {
        public IUnitState State { get; set; }
        public IMovable Movable { get; set; }

        public IUnitState IUnitState
        {
            get => default;
            set
            {
            }
        }

        public Memento Memento
        {
            get => default;
            set
            {
            }
        }

        public ICommand ICommand
        {
            get => default;
            set
            {
            }
        }

        static int count = 0;
        public string name;
        public Unit()
        {
            name = $"Unit {count++}";
        }

        public Unit(IUnitState state) : this()
        {
            State = state;
        }

        public Unit(IUnitState state, IMovable movable) : this()
        {
            State = state;
            Movable = movable;
        }

        public void Jump() => State.Jump(this);
        public void Run() => State.Run(this);
        public void Duck() => State.Duck(this);

        public void Move() => Movable.Move(this);

        public Memento CreateMemento() => new Memento(State, name);
        public void SetMemento(Memento memento)
        {
            State = memento.UnitState;
            name = memento.Name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
