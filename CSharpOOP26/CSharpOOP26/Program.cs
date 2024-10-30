using System;

class Program
{
    static void Main()
    {
        // Lê o valor de N
        Console.Write("Digite um valor N: ");
        int N = int.Parse(Console.ReadLine());

        // Inicializa o fatorial
        long fatorial = 1;

        // Calcula o fatorial
        if (N < 0)
        {
            Console.WriteLine("Fatorial não é definido para números negativos.");
        }
        else
        {
            for (int i = N; i > 1; i--)
            {
                fatorial *= i; // fatorial = fatorial * i
            }

            // O fatorial de 0 é 1, então, se N for 0, devemos garantir que o resultado seja 1
            Console.WriteLine($"Fatorial de {N} é {fatorial}");
        }
    }
}
