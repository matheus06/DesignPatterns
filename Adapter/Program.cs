using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter(new Adaptee());
            target.Request();

            Console.ReadKey(); 
        }
    }
}
