using Strategy.Context;

namespace Strategy.Strategies
{
    public interface IEscolhaDeTrasnportadora
    {
        string EscolherTransprotadoraPara(Pedido pedido);
    }
}