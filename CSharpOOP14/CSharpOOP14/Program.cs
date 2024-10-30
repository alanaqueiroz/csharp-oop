using System;
using System.Globalization;

namespace CSharpOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total = 0.0;

            Console.WriteLine("Digite o código do item: ");
            codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade desse item: ");
            quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("Código inválido.");
                return;
            }

            Console.WriteLine("O total a pagar é: " + total.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
