using System;

namespace Exercicio3_2 //PARTE 3: ESTRUTURAS REPETITIVAS - Exercício 3.2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de entradas:");
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
