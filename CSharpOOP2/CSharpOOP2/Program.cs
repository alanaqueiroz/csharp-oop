using System;

namespace CSharpOOP3 //Saída de Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Name";

            Console.Write("Hello");
            Console.WriteLine(" World!"); // inclui quebra de linha
            Console.WriteLine("---------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // Formata com 2 casas decimais
            Console.WriteLine(saldo.ToString("F4")); // Formata com 4 casas decimais
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Corrigido
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome);
        }
    }
}
