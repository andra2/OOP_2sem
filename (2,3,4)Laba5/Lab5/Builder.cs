using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IBuilder
    {
        void BuildId();
        void BuildCreator();
        void BuildType();
    }
    class Builder
    {

    }

    public class ConcreteBuilder : IBuilder
    {
        private Plane _plane = new Plane();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._plane = new Plane();
        }

        public void BuildId()
        {
            //this._plane.Add("PartA1");
        }

        public void BuildCreator()
        {
            //this._plane.Add("PartB1");
        }

        public void BuildType()
        {
            //this._plane.Add("PartC1");
        }

        // Конкретные Строители должны предоставить свои собственные методы
        // получения результатов. Это связано с тем, что различные типы
        // строителей могут создавать совершенно разные продукты с разными
        // интерфейсами. Поэтому такие методы не могут быть объявлены в базовом
        // интерфейсе Строителя (по крайней мере, в статически типизированном
        // языке программирования).
        //
        // Как правило, после возвращения конечного результата клиенту,
        // экземпляр строителя должен быть готов к началу производства
        // следующего продукта. Поэтому обычной практикой является вызов метода
        // сброса в конце тела метода GetProduct. Однако такое поведение не
        // является обязательным, вы можете заставить своих строителей ждать
        // явного запроса на сброс из кода клиента, прежде чем избавиться от
        // предыдущего результата.
    }
}

