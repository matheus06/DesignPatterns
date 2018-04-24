using ObserverVariation.Observer;

namespace ObserverVariation.Subject
{
    public interface IAcaoBolsa
    {
        void AdicionarInscricao(IInvestidor investidor);
        void RemoverInsricao(IInvestidor investidor);
        void NotificarValor();
        double RetornaValor();
    }
}