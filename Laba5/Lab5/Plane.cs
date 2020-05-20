using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Plane
    {
        public Plane()
        {
            type = Type.passenger;
            Id = 1;
        }
        public Plane(string id,string typ,string model,int seats,DateTime date,string carrying)
        {
            Id = int.Parse(id);
            switch (typ)
            {
                case "passenger":
                    type = Type.passenger;
                    break;
                case "military":
                    type = Type.military;
                    break;
                case "cargo":
                    type = Type.cargo;
                    break;
            }

        }
        public int Id { get; set; }
        public enum Type
        {
            passenger,
            cargo,
            military
        }
        public Type type;
        public enum Model
        {
            AIRBUS,
            Boeing,
            Raytheon
        }

        public LinkedList<CrewMember> Crew;

        public int NofSeats;

        public DateTime DateOfIssue;

        public int carrying;
        public string creator;

    }
}
