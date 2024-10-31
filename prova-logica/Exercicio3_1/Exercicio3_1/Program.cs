using System;

namespace Exercicio3_1 //PARTE 3: ESTRUTURAS REPETITIVAS - Exercício 3.1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
