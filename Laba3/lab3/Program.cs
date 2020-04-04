using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander commander = new Commander();
            Unit unit = new Unit(new JumpUnitState(), new MoveStrategy());
            Memento memento;
            commander.Command();

            unit.Jump();
            unit.Run();
            unit.Duck();
            unit.Jump();
            unit.Duck();
            unit.Run();

            memento = unit.CreateMemento();
            unit.name = "Changed unit";
            unit.Jump();
            unit.Duck();
            unit.SetMemento(memento);
            unit.Run();
            Console.WriteLine();

            unit.Move();
            unit.Movable = new DuckStrategy();
            unit.Move();
        }
    }
}
