using System;
using System.Globalization;

namespace CSharpOOP5 //Estrutura Sequencial - Exercício 1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, soma;

            Console.WriteLine("Escreva o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine($"Soma = {soma}");
        }
    }
}