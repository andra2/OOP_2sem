using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public interface IUnitState
    {
        void Jump(Unit unit);
        void Run(Unit unit);
        void Duck(Unit unit);
    }

    public class DuckUnitState : IUnitState
    {
        public void Jump(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} встает и прыгает") ;
            unit.State = new JumpUnitState();
        }

        public void Run(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} встает и начинает бежать");
            unit.State = new RunUnitState();
        }

        public void Duck(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} продолжает сидеть");
        }
    }

    public class JumpUnitState : IUnitState
    {
        public void Jump(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} продолжает прыгать");
        }

        public void Run(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} перестает прыгать и начинает бежать");
            unit.State = new RunUnitState();
        }

        public void Duck(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} перестает прыгать и приседает");
            unit.State = new DuckUnitState();
        }
    }

    public class RunUnitState : IUnitState
    {
        public void Jump(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} останавливается и начинает прыгать");
            unit.State = new JumpUnitState();
        }

        public void Run(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} продолжает бежать");
        }

        public void Duck(Unit unit)
        {
            Console.WriteLine($"{unit.ToString()} останавливается и приседает");
            unit.State = new DuckUnitState();
        }
    }
}
