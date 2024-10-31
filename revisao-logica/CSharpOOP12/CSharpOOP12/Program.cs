using System;
using System.Globalization;

namespace CSharpOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero para determinar se par ou ímpar: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}
