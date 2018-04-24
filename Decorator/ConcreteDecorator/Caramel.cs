using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Caramel : IAddonDecorator
    {
        private readonly IBeverage _beverage;

        public Caramel(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public double Cost()
        {
            return _beverage.Cost() + 7;
        }
    }
}
