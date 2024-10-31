using System;

namespace CSharpOOP1 //Tipos de Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //controle de verdadeiro ou falso
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 4.5f;
            string nome = "John";
            object obj1 = "Mary";
            object obj2 = 4.5f;
            int n6 = int.MinValue;
            int n7 = int.MaxValue;
            sbyte n8 = sbyte.MinValue;
            decimal n9 = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
        }
    }
}
