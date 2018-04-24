using Strategy.Strategies;

namespace Strategy.Context
{
    public class Pedido
    {
        public string Transportadora { get; set; }
        public decimal Frete { get; set; }

        // utilizando composição: o pedido mantém uma referência
        // para a Strategy base, normalmente uma interface ou classe abstrata
        private ICalculadorDeFrete _calculadorDeFrete;
        private IEscolhaDeTrasnportadora _escolhaDeTrasnportadora;

        public Pedido(ICalculadorDeFrete calculadorDeFrete, IEscolhaDeTrasnportadora escolherTrasnportadora)
        {
            _calculadorDeFrete = calculadorDeFrete;
            _escolhaDeTrasnportadora = escolherTrasnportadora;
        }

        public void CalcularFrete()
        {
            // delegando o cálculo do frete para o objeto Strategy configurado
             _calculadorDeFrete.CalcularFretePara(this);
        }

        public string EscolherTransportadora()
        {
            // delegando a escolha da transportadora para o objeto Strategy configurado
            return _escolhaDeTrasnportadora.EscolherTransprotadoraPara(this);
        }
    }
}
