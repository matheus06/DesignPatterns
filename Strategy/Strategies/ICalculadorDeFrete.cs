using Strategy.Context;

namespace Strategy.Strategies
{
    public interface ICalculadorDeFrete
    {
        void CalcularFretePara(Pedido pedido);
    }
}