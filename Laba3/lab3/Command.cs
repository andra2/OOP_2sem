using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public interface ICommand
    {
        void Execute();
    }

    public class JumpCommand : ICommand
    {
        private readonly Unit _unit;
        public JumpCommand(Unit unit)
        {
            _unit = unit;
        }

        public void Execute()
        {
            Console.WriteLine($"{_unit.ToString()} Прыгнул");
        }
    }

    public class FireCommand : ICommand
    {
        private readonly Unit _unit;
        public FireCommand(Unit unit)
        {
            _unit = unit;
        }

        public void Execute()
        {
            Console.WriteLine($"{_unit.ToString()} Выстрелил");
        }
    }

    public class DuckCommand : ICommand
    {
        private readonly Unit _unit;
        public DuckCommand(Unit unit)
        {
            _unit = unit;
        }

        public void Execute()
        {
            Console.WriteLine($"{_unit.ToString()} Присел");
        }
    }
}
