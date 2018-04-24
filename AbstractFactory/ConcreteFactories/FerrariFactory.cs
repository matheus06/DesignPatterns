using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProductA;
using AbstractFactory.AbstractProductB;
using AbstractFactory.ConcreteProductA;
using AbstractFactory.ConcreteProductB;

namespace AbstractFactory.ConcreteFactories
{
    public class FerrariFactory : ICarFactory
    {

        public ISportingCar CreateSportingCar()
        {
            return new SportingFerrari();
        }

        public IClassicCar CreateClassicCar()
        {
            return new Ferrari();
        }
    }
}
