using AbstractFactory.AbstractProductB;

namespace AbstractFactory.ConcreteProductB
{
    public class Ferrari : IClassicCar
    {
        public string ShowNameAndInfo()
        {
            return "Classic Ferrari";
        }
    }
}