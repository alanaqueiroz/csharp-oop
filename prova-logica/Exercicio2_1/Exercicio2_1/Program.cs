using System;
using System.Globalization;

namespace Exercicio2_1 //PARTE 2: ESTRUTURA CONDICIONAL - Exercício 2.1
{
    class Program
    {
        static void Main(string[] args)
        {
            double codigo, quantidade, preco = 0, total;

            Console.WriteLine("Digite o código do pedido: ");
            codigo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            quantidade = double.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                preco = 4.00;
            }
            else if (codigo == 2)
            {
                preco = 4.50;
            }
            else if (codigo == 3)
            {
                preco = 5.00;
            }
            else if (codigo == 4)
            {
                preco = 2.00;
            }
            else if (codigo == 5)
            {
                preco = 1.50;
            }
            else
            {
                Console.WriteLine("Código inválido.");
                return;
            }

            total = preco * quantidade;

            Console.WriteLine("O valor total a pagar é de: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
