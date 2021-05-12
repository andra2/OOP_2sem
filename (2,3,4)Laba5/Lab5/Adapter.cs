using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IHuman
    {
        string Name { get; set; }
        int Age { get; set; }
        string Profession { get; set; }
    }
    class Teacher : IHuman
    {
        public int Experience { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public Teacher()
        {
            Experience = 2;
            Name = "Андрей";
            Age = 20;
            Profession = "";
        }
    }

    public class Adapter : Pilot
    {
        private Teacher teacher = new Teacher();
        public Adapter()
        {
            this.Age = teacher.Age;
            this.Experience = teacher.Experience;
            this.Name = teacher.Name;
            this.Position = teacher.Profession;
        }
    }
}
