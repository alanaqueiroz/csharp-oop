using System;
using System.Globalization;

namespace CSharpOOP6 //Estrutura Sequencial - Exercício 1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o número do funcionário:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora:");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = $ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}