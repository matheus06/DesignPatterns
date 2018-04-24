using Strategy.Context;
using Strategy.Strategies;

namespace Strategy.ConcreteStrategies
{
    class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public void CalcularFretePara(Pedido pedido)
        {
            pedido.Frete= 10;
        }
    }
}
