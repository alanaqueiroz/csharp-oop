using System;
using System.Globalization;

namespace CSharpOOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero para calcular seu intervalo: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (numero >= 0 && numero < 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (numero >= 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else if (numero < 0 && numero > 100)
            {
                Console.WriteLine("Fora de intervalo.");
            }
        }
    }
}