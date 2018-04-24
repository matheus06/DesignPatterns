
using Strategy.Context;
using Strategy.Strategies;

namespace Strategy.ConcreteStrategies
{
    class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public void CalcularFretePara(Pedido pedido)
        {
            pedido.Frete = 20;
        }
    }
}
