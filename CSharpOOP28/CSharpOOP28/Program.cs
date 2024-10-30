using System;

class Program
{
    static void Main()
    {
        // Lê um número inteiro positivo N
        Console.Write("Digite um número inteiro positivo N: ");
        int N = int.Parse(Console.ReadLine());

        // Verifica se N é positivo
        if (N <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
            return; // Encerra o programa se N não for positivo
        }

        // Exibe N linhas com o número, seu quadrado e cubo
        Console.WriteLine("Linha | Quadrado | Cubo");
        Console.WriteLine("------------------------");

        for (int i = 1; i <= N; i++)
        {
            // Calcula o quadrado e o cubo
            int quadrado = i * i;
            int cubo = i * i * i;

            // Exibe os resultados formatados
            Console.WriteLine($"{i,-6} | {quadrado,-9} | {cubo,-4}");
        }
    }
}
