using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractA concreta = new ConcretaA(new ConcretaB1());

            Console.WriteLine(concreta.Virtual1());
            Console.WriteLine(concreta.MetodoA1());
            Console.WriteLine(concreta.MetodoA2());

            concreta = new ConcretaA(new ConcretaB2());

            Console.WriteLine(concreta.Virtual1());
            Console.WriteLine(concreta.MetodoA1());
            Console.WriteLine(concreta.MetodoA2());

            Console.ReadKey();
        }
    }
}
