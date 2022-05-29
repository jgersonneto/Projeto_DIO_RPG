using projeto_dio_1.src.Entities;

namespace projeto_dio_1
{
    class Program
    {

        static void Main(String[] args)
        {
            Knight arus = new Knight("Arus", 12, "Guerreiro", 50, 5);
            Ninja wedge = new Ninja("Wedge", 12, "Ninja", 35, 15);
            WhiteWizard jenica = new WhiteWizard("Jenica", 12, "Mago Branco", 25, 55);
            BlackWizard topapa = new BlackWizard("Topapa", 12, "Guerreiro", 35, 60);

            Console.WriteLine("----------- Dados do Herois ------------");
            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(jenica);
            Console.WriteLine(topapa);
            Console.WriteLine("----------- Fim dos Dados ------------");
            Console.WriteLine();
            Console.WriteLine("----------- Ataque do Herois ------------");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(topapa.Attack());
            Console.WriteLine("----------- Fim dos Ataque ------------");
            Console.WriteLine();
            Console.WriteLine("----------- Ataque com Danos do Herois ------------");
            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(wedge.Attack(3));
            Console.WriteLine(jenica.Attack(6));
            Console.WriteLine(topapa.Attack(1));
            Console.WriteLine("----------- Ataque com Danos ------------");

        }
    }

}