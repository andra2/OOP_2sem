using System;
using System.Collections;
namespace Laba1
{
    class Program
    {
        class Commander
        {
            private static Commander instance;
            public static Commander GetInstance()
            {
                if (instance == null)
                {
                    instance=new Commander();
                }
                return instance;
            }
            private Commander()
            {
                
            }

            public void CreateArcher() 
            {
                //todo
            }
            public void CreateSolder() 
            {
                //todo
            }
        }
        class Minion
        {
            private AbsBody body;
            private AbsWeapon weapon;

            public Minion(AbstractFactory factory)
            {
                body = factory.CreateBody();
                weapon = factory.CreateWeapon();
            }

            public void Attack() { Console.WriteLine("атакуем"); }
            public void Wait() { Console.WriteLine("ждем"); }
            public int health;
            public int stamina;
        }
        class Sword : AbsWeapon { }
        class Human : AbsBody { }
        class Elf : AbsBody { }
        class Bow : AbsWeapon { }
        abstract class AbstractFactory
        {
            abstract public AbsBody CreateBody();
            abstract public AbsWeapon CreateWeapon();
        }
        abstract class AbsWeapon
        {

        }
        abstract class AbsBody
        {

        }
        class Kazarma : AbstractFactory
        {
            public override AbsBody CreateBody()
            {
                return new Human();
            }
            public override AbsWeapon CreateWeapon()
            {
                return new Sword();
            }
        }

        class ShootingRange : AbstractFactory
        {
            public override AbsBody CreateBody()
            {
                return new Elf();
            }
            public override AbsWeapon CreateWeapon()
            {
                return new Bow();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
