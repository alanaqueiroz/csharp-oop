using System;

namespace CSharpOOP17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1;

            while (x != 0 && y != 0)
            {
                Console.Write("Digite o valor de x: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor de y: ");
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}
