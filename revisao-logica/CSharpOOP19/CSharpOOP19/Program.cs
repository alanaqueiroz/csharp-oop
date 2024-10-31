using System;
using System.Globalization;

namespace CSharpOOP16
{
    class Program
    {
        static void Main(string[] args)
        {
            double senha;

            Console.WriteLine("Digite a senha: ");
            senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}