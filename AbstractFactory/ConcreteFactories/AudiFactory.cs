using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProductA;
using AbstractFactory.AbstractProductB;
using AbstractFactory.ConcreteProductA;
using AbstractFactory.ConcreteProductB;

namespace AbstractFactory.ConcreteFactories
{
    public class AudiFactory : ICarFactory
    {
        public IClassicCar CreateClassicCar()
        {
            return new Audi();
        }

        public ISportingCar CreateSportingCar()
        {
            return new SportingAudi();
        }
    }
}
