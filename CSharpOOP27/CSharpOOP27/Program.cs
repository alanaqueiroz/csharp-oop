using System;

class Program
{
    static void Main()
    {
        // Lê o número inteiro N
        Console.Write("Digite um número inteiro N: ");
        int N = int.Parse(Console.ReadLine());

        // Exibe os divisores de N
        Console.WriteLine($"Divisores de {N}:");

        // Verifica e imprime os divisores
        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0) // Se o resto da divisão for zero, i é um divisor
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine(); // Nova linha após listar todos os divisores
    }
}
