using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract  class AbstractA
    {
        private IInterfaceB _interfaceB;
        public AbstractA(IInterfaceB interfaceB)
        {
            _interfaceB = interfaceB;
        }

        public string MetodoA1()
        {
            return _interfaceB.MetodoB1();
        }

        public string MetodoA2()
        {
            return _interfaceB.MetodoB2();
        }

        public virtual string Virtual1()
        {
            return "x";
        }
    }
}
