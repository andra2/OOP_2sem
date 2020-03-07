﻿using System;
using System.Collections.Generic;
namespace Laba1
{
    class Program
    {
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

    class Commander
    {
        public List<Minion> army = new List<Minion>();
        private static Commander instance;
        public static Commander GetInstance()
        {
            if (instance == null)
            {
                instance = new Commander();
            }
            return instance;
        }
        private Commander()
        {

        }
        public void Construct(int amount, AbstractFactory factory)
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
            Console.WriteLine("Армия состоит из:");
            foreach (Minion m in army)
            {
                Console.WriteLine(m.body.ToString() + " " + m.weapon.ToString());
            }
            Console.WriteLine("Количество войнов = {0}", army.Count);
        }
    }
    class Sword : AbsWeapon
    {

    }
    class Human : AbsBody
    {

    }
    class Elf : AbsBody
    {

    }
    class Bow : AbsWeapon
    {

    }
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

}
