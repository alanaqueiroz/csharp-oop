﻿using System;
using System.Globalization;

class HelloWorld
{
    static void Main()
    {
        double xA, xB, xC, yA, yB, yC;

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pX = (xA + xB + xC) / 2.0;
        double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

        double pY = (yA + yB + yC) / 2.0;
        double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área: X");
        }
        else
        {
            Console.WriteLine("Maior área: Y");
        }
    }
}
