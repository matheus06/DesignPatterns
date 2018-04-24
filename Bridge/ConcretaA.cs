using System;

namespace Bridge
{
    public class ConcretaA : AbstractA
    {
        public ConcretaA(IInterfaceB interfaceB) : base(interfaceB)
        {
        }

        public override string Virtual1()
        {
            return "Virtual 1";
        }

        
    }
}