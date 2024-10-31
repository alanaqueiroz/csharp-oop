using System;
using System.Globalization;

namespace CSharpOOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dif, a, b, c, d;

            Console.WriteLine("Digite o numero A:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o numero B:");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o numero C:");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o numero D:");
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dif = (a * b - c * d);

            Console.WriteLine("A diferença entre eles é = " + dif.ToString(CultureInfo.InvariantCulture));
        }
    }
}

