using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    abstract class Decorator : Unit
    {
        protected Swordsman component;

        public void SetComponent(Swordsman component)
        {
            this.component = component;
        }
        public override void  Draw()
        {
            base.Draw();
        }
        public Decorator(string name) : base(name) { }
    }
    class CoolerMinion : Decorator
    {
        public CoolerMinion(string name) : base(name) { }
        public override void Draw()
        {
            Console.Write("крутой ");
            base.Draw();
        }
    }

}
