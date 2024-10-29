using System;
using System.Globalization;

namespace CSharpOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;

            Console.WriteLine("Digite que horas o jogo comecou: ");
            inicio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite que horas o jogo terminou: ");
            fim = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (inicio < fim)
            {
                duracao = inicio - fim;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O jogo durou: " + duracao + " horas");
        }
    }
}
