using System;
using System.Globalization;

namespace CSharpOOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Digite as coordenadas para X: ");
            x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite as coordenadas para Y: ");
            y = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}