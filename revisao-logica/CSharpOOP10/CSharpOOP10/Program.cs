using System;
using System.Globalization;

namespace CSharpOOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um valor para C: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("Triângulo = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
