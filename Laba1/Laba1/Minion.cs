using System;
namespace Laba1
{
    class Minion
    {
        public readonly AbsBody body;
        public readonly AbsWeapon weapon;

        private Minion()
        {

        }
        private Minion(AbsBody b, AbsWeapon w)
        {
            body = b;
            weapon = w;
        }
        public Minion(AbstractFactory factory)
        {
            body = factory.CreateBody();
            weapon = factory.CreateWeapon();
        }
        public Minion(AbstractFactory forBody, AbstractFactory forWeapon)
        {
            body = forBody.CreateBody();
            weapon = forWeapon.CreateWeapon();
        }
        public void Attack() { Console.WriteLine("атакуем"); }
        public void Wait() { Console.WriteLine("ждем"); }
        public Minion Clone()
        {
            return new Minion(body, weapon);
        }
    }

}
