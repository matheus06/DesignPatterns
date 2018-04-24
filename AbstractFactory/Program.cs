using System;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var ferrariFactory = new FerrariFactory();
            var ferrariClassic = ferrariFactory.CreateClassicCar();
            var ferrariSporting = ferrariFactory.CreateSportingCar();

            var audiFactory = new AudiFactory();
            var audiClassic = audiFactory.CreateClassicCar();
            var audiSporting = audiFactory.CreateSportingCar();

            Console.WriteLine("Car type and name: {0}", ferrariClassic.ShowNameAndInfo());
            Console.WriteLine("Car type and name: {0}", ferrariSporting.ShowNameAndInfo());
            Console.WriteLine("Car type and name: {0}", audiClassic.ShowNameAndInfo());
            Console.WriteLine("Car type and name: {0}", audiSporting.ShowNameAndInfo());

            Console.ReadKey();
        }
    }
}
