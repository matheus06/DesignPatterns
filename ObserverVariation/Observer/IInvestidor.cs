using ObserverVariation.Subject;

namespace ObserverVariation.Observer
{
    public interface IInvestidor
    {
        void Atualizar(IAcaoBolsa acao);
    }
}