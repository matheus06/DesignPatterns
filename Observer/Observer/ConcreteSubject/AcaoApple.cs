using System.Collections.Generic;
using Observer.Observer;
using Observer.Subject;

namespace Observer.ConcreteSubject
{
    public class AcaoApple : IAcaoBolsa
    {

        private readonly List<IInvestidor> _observers = new List<IInvestidor>();
        public double Valor { get; set; }

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
                investidor.Atualizar();
            }
        }

        public double RetornaValor()
        {
            return Valor;
        }
    }
}
