using System;
using System.Globalization;

namespace Exercicio1_1 //PARTE 1: ESTRUTURA SEQUENCIAL - Exercício 1.1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod_p1, num_p1, cod_p2, num_p2;
            double valor_p1, valor_p2, total;

            Console.WriteLine("Digite o código da primeira peça:");
            cod_p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas unidades da primeira peça:");
            num_p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da primeira peça:");
            valor_p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o código da segunda peça:");
            cod_p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas unidades da segunda peça:");
            num_p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da segunda peça:");
            valor_p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (num_p1 * valor_p1) + (num_p2 * valor_p2);

            Console.WriteLine("O total a pagar é: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
