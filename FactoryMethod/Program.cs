using System;
using FactoryMethod.ConcreteCreator;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FerrariFactory();
            var car = factory.CreateCar();

            var audiFactory = new AudiFactory();
            var secondCar = audiFactory.CreateCar();

            Console.WriteLine("Car Name: {0}", car.ShowName());
            Console.WriteLine("Car Name: {0}", secondCar.ShowName());
            Console.ReadKey();
        }
    }
}
