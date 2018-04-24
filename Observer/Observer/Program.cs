using System;
using Observer.ConcreteObserver;
using Observer.ConcreteSubject;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AcaoApple acaoApple = new AcaoApple();

            Investidor investidor = new Investidor(acaoApple);
            Investidor investidor1 = new Investidor(acaoApple);
            Investidor investidor2 = new Investidor(acaoApple);
            Investidor investidor3 = new Investidor(acaoApple);
            Investidor investidor4 = new Investidor(acaoApple);
            
            acaoApple.AdicionarInscricao(investidor);
            acaoApple.AdicionarInscricao(investidor1);
            acaoApple.AdicionarInscricao(investidor2);
            acaoApple.AdicionarInscricao(investidor3);
            acaoApple.AdicionarInscricao(investidor4);


            acaoApple.Valor = 4;
            acaoApple.NotificarValor();

            acaoApple.RemoverInsricao(investidor4);

            acaoApple.Valor = 5;
            acaoApple.NotificarValor();


            Console.ReadKey();
        }
    }
}
