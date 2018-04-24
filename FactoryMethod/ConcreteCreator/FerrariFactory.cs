using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class FerrariFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Ferrari();
        }
    }
}
