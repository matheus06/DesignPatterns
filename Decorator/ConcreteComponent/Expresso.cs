using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class Expresso : IBeverage
    {
        public double Cost()
        {
            return 5;
        }
    }
}
