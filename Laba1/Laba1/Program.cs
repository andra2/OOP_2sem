using System;
using System.Collections.Generic;
namespace Laba1
{
    class Program
    {
        class Commander                        
        {
            public List<Minion> army = new List<Minion>();
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
            public void Construct(int amount,AbstractFactory factory)
            {
                for (int i = 0; i < amount; i++)
                {
                    army.Add(new Minion(factory));
                }
            }
            public void Construct(int amount, AbstractFactory bodyFactory, AbstractFactory weaponFactory)
            {
                for (int i = 0; i < amount; i++)
                {
                    army.Add(new Minion(bodyFactory, weaponFactory));
                }
            }
            public void ShowArmy()
            {
                int stam=0;
                int count = 0;
                int hp = 0;
                Console.WriteLine("Армия состоит из:");
                foreach (Minion m in army)
                {
                    count++;
                    stam += m.weapon.s;
                    hp += m.body.h;
                    //Console.WriteLine(m.body.name +" c "+ m.weapon.name);
                }
                Console.WriteLine("Выносливость армии = {0}\nКоличество войнов = {1}\nЗдоровье армии = {2}", stam.ToString(), count.ToString(), hp.ToString());
            } 
        }
        class Minion
        {
            public readonly AbsBody body;
            public readonly AbsWeapon weapon;

            private Minion()
            {
                
            }
            private Minion(AbsBody b,AbsWeapon w)
            {
                body = b;
                weapon = w;
            }
            public Minion(AbstractFactory factory)
            {
                body = factory.CreateBody();
                weapon = factory.CreateWeapon();
            }
            public Minion(AbstractFactory forBody,AbstractFactory forWeapon)
            {
                body = forBody.CreateBody();
                weapon = forWeapon.CreateWeapon();
            }
            public void Attack() { Console.WriteLine("атакуем"); }
            public void Wait() { Console.WriteLine("ждем"); }
            public Minion Clone()
            {
                return new Minion(body,weapon);
            } 
        }
        class Sword : AbsWeapon 
        {
            new public readonly string n = "меч";
            new public readonly int s = 15;
        }
        class Human : AbsBody 
        {
            new public readonly string n= "человек";
            new public readonly int h = 30;
        }
        class Elf : AbsBody 
        {
            public readonly string n = "эльф";
            public readonly int h = 20;
        }
        class Bow : AbsWeapon 
        {
            public readonly string n = "лук";
            public readonly int s= 30;
        }
        abstract class AbstractFactory
        {
            abstract public AbsBody CreateBody();
            abstract public AbsWeapon CreateWeapon();
        }
        abstract class AbsWeapon
        {
            public readonly string n;
            public readonly int s;
        }
        abstract class AbsBody
        {
            public readonly string n;
            public readonly int h;
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
            Commander commander = Commander.GetInstance();
            ShootingRange range = new ShootingRange();
            Kazarma kazarma = new Kazarma();

            commander.Construct(3,range);
            commander.Construct(8, kazarma, range);
            commander.ShowArmy();
        }
    }
}
