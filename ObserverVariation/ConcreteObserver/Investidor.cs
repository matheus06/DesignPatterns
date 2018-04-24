using System;
using ObserverVariation.ConcreteSubject;
using ObserverVariation.Observer;
using ObserverVariation.Subject;

namespace ObserverVariation.ConcreteObserver
{
    public class Investidor : IInvestidor
    {
        private double _valor;

        //Posso passar o valor já em (double valor)
        //Posso passar uma classe herdada de uma classe abstract onde já terei o método de retornar valor nela.
        public void Atualizar(IAcaoBolsa acao)
        {
            _valor = acao.RetornaValor();
            Console.WriteLine("Valor: {0}", _valor);
        }
    }
}
