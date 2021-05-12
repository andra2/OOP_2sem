namespace Lab5
{

    abstract class AbstractFactory
    {
        public abstract CrewMember CreateMember(string pos, string name, int age, int exp);

        public abstract CrewMember CreateMember();
    }

    class PilotFactory : AbstractFactory
    {
        public override CrewMember CreateMember(string pos, string name, int age, int exp)
        {
            return new Pilot(pos, name, age, exp);
        }

        public override CrewMember CreateMember()
        {
            return new Pilot();
        }
    }

    class StewardFactory : AbstractFactory
    {
        public override CrewMember CreateMember(string pos, string name, int age, int exp)
        {
            return new Steward(pos, name, age, exp);
        }
        public override CrewMember CreateMember()
        {
            return new Steward();
        }
    }

    public class Pilot : CrewMember
    {
        public Pilot(string pos, string name, int age, int exp)
        {
            Name = name;
            Age = age;
            Experience = exp;
            Position = pos;
        }

        public Pilot()
        {

        }
    }

    public class Steward : CrewMember
    {
        public Steward(string pos, string name, int age, int exp)
        {
            Name = name;
            Age = age;
            Experience = exp;
            Position = pos;
        }
        public Steward()
        {

        }
    }

    class Client
    {
        private CrewMember crewMember;

        public CrewMember GetMember()
        {
            return crewMember;
        }

        public Client(AbstractFactory factory, string pos, string name, int age, int exp)
        {
            crewMember = factory.CreateMember(pos, name, age, exp);
        }
        public Client(AbstractFactory factory)
        {
            crewMember = factory.CreateMember();
        }
    }
}
