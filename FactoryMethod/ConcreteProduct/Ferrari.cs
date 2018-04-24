using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Ferrari : ICar
    {
        public static string Nome = "Ferrari";
        public string ShowName()
        {
            return Nome;
        }
    }
}