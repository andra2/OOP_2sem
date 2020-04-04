using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Commander
    {
        private readonly Unit _unit = new Unit();

        public Unit Unit
        {
            get => default;
            set { }
        }

        public void Command()
        {
            ICommand command;
            int sw = 0;
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Jump");
            Console.WriteLine("2 - Fire");
            Console.WriteLine("3 - Duck");
            Console.WriteLine("0 - Exit");
            while (true)
            {
                try
                {
                    sw = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                switch (sw)
                {
                    case 1:
                        command = new JumpCommand(_unit);
                        break;
                    case 2:
                        command = new FireCommand(_unit);
                        break;
                    case 3:
                        command = new DuckCommand(_unit);
                        break;
                    default:
                        return;
                }
                command.Execute();
            }
        }
    }
}
