using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab5
{
    public interface IBuilder
    {
        void BuildId(int id);
        void BuildCreator(string creator);
        void BuildType(Plane.Type type);
        void BuildSeats(int n);
        void BuildDate(DateTime date);
        void BuildCarry(string carr);
    }
    class Builder
    {

    }

    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        //public void BuildMinimalViableProduct()
        //{
        //    this._builder.BuildId(0);
        //}

        public void BuildFullFeaturedPlane(int id,string creator,Plane.Type type,int seats,DateTime date,string carry)
        {
            this._builder.BuildId(id);
            this._builder.BuildCreator(creator);
            this._builder.BuildType(type);
            this._builder.BuildSeats(seats);
            this._builder.BuildDate(date);
            this._builder.BuildCarry(carry);
        }
    }
    public class ConcreteBuilder : IBuilder
    {
        private Airport main;
        private Plane _plane = new Plane();
        public ConcreteBuilder(Airport form)
        {
            this.Reset();
            main = form;
        }

        public void Reset()
        {
            this._plane = new Plane();
        }

        public void BuildId(int id)
        {
            foreach(Plane p in main.Planes)
            {
                if (p.Id == id)
                {
                    id = 0;

                }
            }
            this._plane.Id = id;
        }

        public void BuildCreator(string cr)
        {
            this._plane.creator = cr;
        }

        public void BuildType(Plane.Type type)
        {
            this._plane.type = type;
        }

        public void BuildSeats(int no) 
        {
            this._plane.NofSeats = no;
        }
        public void BuildDate(DateTime date)
        {
            this._plane.DateOfIssue = date;
        }
        public void BuildCarry(string carr)
        {
            this._plane.carrying = carr;
        }
        public Plane GetPlane()
        {
            Plane result = this._plane;

            this.Reset();

            return result;
        }


    }
}

