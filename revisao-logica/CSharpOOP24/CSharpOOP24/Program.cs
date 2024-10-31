using System;
using System.Globalization;

namespace CSharpOOP24
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double peso1 = 2;
                double peso2 = 3;
                double peso3 = 5;

                double mediaPonderada = (v1 * peso1 + v2 * peso2 + v3 * peso3) / (peso1 + peso2 + peso3);

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
