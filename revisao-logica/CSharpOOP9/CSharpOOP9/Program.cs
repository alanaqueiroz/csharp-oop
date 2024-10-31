using System;
using System.Globalization;

namespace CSharpOOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod_p1, cod_p2;
            double quant_p1, quant_p2, valor_p1, valor_p2, total;

            Console.WriteLine("Digite o código da primeira peça de roupa (número inteiro): ");
            cod_p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças da primeira peça de roupa: ");
            quant_p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor unitário da primeira peça de roupa: ");
            valor_p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o código da segunda peça de roupa (número inteiro): ");
            cod_p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças da segunda peça de roupa: ");
            quant_p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor unitário da segunda peça de roupa: ");
            valor_p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = valor_p1 * quant_p1 + valor_p2 * quant_p2;

            Console.WriteLine("O valor total a ser pago é de: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
