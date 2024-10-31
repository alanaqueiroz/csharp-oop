using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de quartos na sua casa:");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço de um produto:");
        double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
        string[] dados = Console.ReadLine().Split(' ');
        string ultimoNome = dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

        Console.WriteLine("\nVocê digitou: ");
        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}

