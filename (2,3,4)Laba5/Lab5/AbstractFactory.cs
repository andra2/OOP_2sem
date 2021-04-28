using System;
using System.Collections.Generic;

namespace Lab5
{

    abstract class AbstractFactory
    {
        public abstract AbstractPlane CreatePlane();
    }
    class PlaneFactory : AbstractFactory
    {
        public override AbstractPlane CreatePlane()
        {
            return new ProductA1();
        }
    }

    abstract class AbstractPlane
    {
        public List<CrewMember> Crew;
        public int NofSeats;
        public DateTime DateOfIssue;
        public string carrying;
        public string creator;
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
    }

    class ProductA1 : AbstractPlane
    {
        public ProductA1()
        {
            Crew = new List<CrewMember>();
            NofSeats = 2;
            DateOfIssue = DateTime.Now;
            carrying = "40 т.";
            creator = "";
            type = Type.passenger;
        }
    }

    class Client
    {
        private AbstractPlane abstractPlane;

        public Client(AbstractFactory factory)
        {
            abstractPlane = factory.CreatePlane();
        }
    }
}
