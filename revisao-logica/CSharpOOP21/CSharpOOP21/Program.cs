using System;

namespace CSharpOOP17
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
            Console.WriteLine("Digite o combustível de sua preferência:");

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                else if (tipo == 2)
                {
                    gasolina += 1;
                }
                else if (tipo == 3)
                {
                    diesel += 1;
                }

                Console.WriteLine("Digite o combustível de sua preferência:");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
