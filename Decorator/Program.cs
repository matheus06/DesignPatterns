using System;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Expresso cafeExpresso = new Expresso();
            Caramel cafeExpressoWithCaramel = new Caramel(cafeExpresso);
            Milk cafeExpressoWithCaramelAndMilk = new Milk(cafeExpressoWithCaramel);
            
            Console.WriteLine("Expresso: " + cafeExpresso.Cost());
            Console.WriteLine("Expresso Caramel: " + cafeExpressoWithCaramel.Cost());
            Console.WriteLine("Expresso Caramel And Milk: " + cafeExpressoWithCaramelAndMilk.Cost());
            Console.ReadKey();
        }
    }
}
