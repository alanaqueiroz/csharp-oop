using System;
using System.Globalization;

namespace CSharpOOP11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero para determinar se é negativo: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("O número não é negativo");
            }
        }
    }
}
