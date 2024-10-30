using System;
using System.Globalization;

namespace Exercicio2_2 //PARTE 2: ESTRUTURA CONDICIONAL - Exercício 2.2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double a, b, c;

            Console.WriteLine("Digite o valor do coeficiente A:");
            a = double.Parse(Console.ReadLine(), culture);
            Console.WriteLine("Digite o valor do coeficiente B:");
            b = double.Parse(Console.ReadLine(), culture);
            Console.WriteLine("Digite o valor do coeficiente C:");
            c = double.Parse(Console.ReadLine(), culture);

            double delta = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("X1 = " + x1.ToString("F5", culture));
            Console.WriteLine("X2 = " + x2.ToString("F5", culture));
        }
    }
}
