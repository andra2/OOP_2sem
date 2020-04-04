using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public interface IMovable
    {
        void Move(Unit unit);
    }
    public class MoveStrategy : IMovable
    {
        public void Move(Unit unit)
        {
            unit.Jump();
            unit.Run();
        }
    }

    public class DuckStrategy : IMovable
    {
        public void Move(Unit unit)
        {
            unit.Jump();
            unit.Duck();
        }
    }
}
