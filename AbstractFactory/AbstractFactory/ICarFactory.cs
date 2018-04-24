using AbstractFactory.AbstractProductA;
using AbstractFactory.AbstractProductB;

namespace AbstractFactory.AbstractFactory
{
    public interface ICarFactory
    {
        ISportingCar CreateSportingCar();
        IClassicCar CreateClassicCar();
    }
}
