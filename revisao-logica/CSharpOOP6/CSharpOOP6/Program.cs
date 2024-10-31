using System;
using System.Globalization;

namespace CSharpOOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            Console.WriteLine("Digite o raio da circunferência:");
            raio = double.Parse(Console.ReadLine());

            area = (raio * 2) * pi;

            Console.WriteLine("A área da circunferência é = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
