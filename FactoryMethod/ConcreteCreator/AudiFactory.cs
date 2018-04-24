using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class AudiFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Audi();
        }
    }
}
