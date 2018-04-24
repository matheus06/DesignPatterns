using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Audi : ICar
    {
        public string ShowName()
        {
            return "Audi";
        }
    }
}