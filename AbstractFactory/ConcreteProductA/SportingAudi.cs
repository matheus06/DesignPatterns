using AbstractFactory.AbstractProductA;

namespace AbstractFactory.ConcreteProductA
{
    internal class SportingAudi : ISportingCar
    {
        public string ShowNameAndInfo()
        {
            return "Sporting Audi";
        }
    }
}