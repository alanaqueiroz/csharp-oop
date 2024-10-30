using System;

namespace Exercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de entradas:");
            int N = int.Parse(Console.ReadLine());
            int inside = 0;
            int outside = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número:");
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            Console.WriteLine($"{inside} in");
            Console.WriteLine($"{outside} out");
        }
    }
}
