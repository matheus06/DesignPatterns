using Observer.Observer;

namespace Observer.Subject
{
    interface IAcaoBolsa
    {
        void AdicionarInscricao(IInvestidor investidor);
        void RemoverInsricao(IInvestidor investidor);
        void NotificarValor();
    }
}