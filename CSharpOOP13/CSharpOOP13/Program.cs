using System;
using System.Globalization;

namespace CSharpOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Digite um valor para A: ");
            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um valor para B: ");
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
        }
    }
}
