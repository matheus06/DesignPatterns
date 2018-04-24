using Strategy.Context;
using Strategy.Strategies;

namespace Strategy.ConcreteStrategies
{
    public class EscolhaDeTransportadorPorLocalidade : IEscolhaDeTrasnportadora
    {
        public string EscolherTransprotadoraPara(Pedido pedido)
        {
            return "A";
        }
    }
}
