using AbstractFactory.AbstractProductA;

namespace AbstractFactory.ConcreteProductA
{
    class SportingFerrari : ISportingCar
    {
        public string ShowNameAndInfo()
        {
            return "Sporting Ferrari";
        }
    }
}
