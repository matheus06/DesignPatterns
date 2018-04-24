using System.Collections.Generic;
using ObserverVariation.Observer;
using ObserverVariation.Subject;

namespace ObserverVariation.ConcreteSubject
{
    public class AcaoApple : IAcaoBolsa
    {

        private readonly List<IInvestidor> _observers = new List<IInvestidor>();
        private double _valor;

        public void AdicionarInscricao(IInvestidor observer)
        {
            _observers.Add(observer);
        }

        public void RemoverInsricao(IInvestidor observer)
        {
            _observers.Remove(observer);
        }

        public void NotificarValor()
        {
            foreach (IInvestidor investidor in _observers)
            {
                investidor.Atualizar(this);
                //Posso passar o valor this._valor
            }
        }

        //Posso ter esse método em uma classe base abstract e herdo da mesma ao invés de uma interace
        public double RetornaValor()
        {
            return _valor;
        }

        public double Valor
        {
            get { return _valor; }
            set

            {
                if (_valor != value)
                {
                    _valor = value;
                    NotificarValor();
                }
            }
        }
    }
}
