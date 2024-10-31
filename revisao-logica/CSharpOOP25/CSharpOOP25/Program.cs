using System;

class Program
{
    static void Main()
    {
        // Lê o número N
        Console.Write("Digite o número de pares: ");
        int N = int.Parse(Console.ReadLine());

        // Laço para ler N pares de números
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o par de números {i + 1}:");
            string[] input = Console.ReadLine().Split(' ');

            // Converte os números lidos para inteiros
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            // Realiza a divisão ou imprime a mensagem de erro
            if (num2 == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = (double)num1 / num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
