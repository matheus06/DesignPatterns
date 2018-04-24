using AbstractFactory.AbstractProductB;

namespace AbstractFactory.ConcreteProductB
{
    public class Audi : IClassicCar
    {
        public string ShowNameAndInfo()
        {
            return "Classic Audi";
        }
    }
}