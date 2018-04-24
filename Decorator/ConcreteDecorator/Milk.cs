using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Milk : IAddonDecorator
    {
        private readonly IBeverage _beverage;

        public Milk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double Cost()
        {
            return _beverage.Cost() + 3;
        }
    }
}
