using System;
using Strategy.ConcreteStrategies;
using Strategy.Context;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido(new CalculadorDeFretePadrao(), new EscolhaDeTransportadorPorLocalidade());

            pedido.CalcularFrete();
            pedido.Transportadora = pedido.EscolherTransportadora();

            Console.WriteLine("Frete: "+ pedido.Frete);
            Console.WriteLine("Trasnportadora: " + pedido.Transportadora);
            Console.ReadKey();
        }
    }
}

