using Strategy.Context;
using Strategy.Strategies;

namespace Strategy.ConcreteStrategies
{
    class EscolhaDeTransportadorPorValor : IEscolhaDeTrasnportadora
    {
        public string EscolherTransprotadoraPara(Pedido pedido)
        {
            return "B";
        }
    }
}
