using System;
using Observer.ConcreteSubject;
using Observer.Observer;

namespace Observer.ConcreteObserver
{
    public class Investidor : IInvestidor
    {
        private  AcaoApple _acao;
        private double _valor;

        public Investidor(AcaoApple acao)
        {
            _acao = acao;
        }
        public void Atualizar()
        {
            _valor = _acao.RetornaValor();
            Console.WriteLine("Valor: {0}",  _valor);
        }
    }
}
