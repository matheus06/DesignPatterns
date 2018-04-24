using System;

namespace Adapter
{
    internal class Adaptee : IAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}