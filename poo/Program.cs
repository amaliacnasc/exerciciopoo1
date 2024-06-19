using System;

namespace Csharp.poo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome:\n");
            Pessoa p1 = new Pessoa();
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o ano em que você nasceu:\n");
            p1.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p1.Dados();
        }
    }
}
