using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public interface ICarFactory
    {
        ICar CreateCar();
    }
}
