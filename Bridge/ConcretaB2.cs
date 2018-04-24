using System;

namespace Bridge
{
    public class ConcretaB2 : IInterfaceB
    {
        public string MetodoB1()
        {
            return "ConcretaB2 B1";
        }

        public string MetodoB2()
        {
            return "ConcretaB2 B2";
        }
    }
}