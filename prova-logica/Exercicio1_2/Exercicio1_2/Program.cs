using System;
using System.Globalization;

namespace Exercicio1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            Console.WriteLine("Digite o valor do raio para determinar a área da circunferência: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * (raio * raio);

            Console.WriteLine("A área da circunferência é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
