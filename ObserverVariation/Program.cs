using System;
using ObserverVariation.ConcreteObserver;
using ObserverVariation.ConcreteSubject;

namespace ObserverVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            AcaoApple acaoApple = new AcaoApple();
            AcaoMicrosoft acaoMicrosoft = new AcaoMicrosoft();

            Investidor investidor = new Investidor();
            Investidor investidor1 = new Investidor();
            Investidor investidor2 = new Investidor();
            Investidor investidor3 = new Investidor();
            Investidor investidor4 = new Investidor();

            acaoApple.AdicionarInscricao(investidor);
            acaoApple.AdicionarInscricao(investidor1);
            acaoApple.AdicionarInscricao(investidor2);
            acaoApple.AdicionarInscricao(investidor3);
            acaoApple.AdicionarInscricao(investidor4);

            acaoMicrosoft.AdicionarInscricao(investidor2);

            acaoApple.Valor = 4;
            acaoApple.RemoverInsricao(investidor4);
            acaoApple.Valor = 5;

            acaoMicrosoft.Valor = 12;


            Console.ReadKey();
        }
    }
}
