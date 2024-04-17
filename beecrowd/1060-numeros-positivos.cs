using System;
using System.Globalization;

class Bee1060
{
    static void Main(string[] args)
    {
        // Variáveis
        double n1, n2, n3, n4, n5, n6;
        int cont = 0;

        // Entrada
        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Condicional
        if (n1 > 0)
        {
            cont++;
        }
        if (n2 > 0)
        {
            cont++;
        }
        if (n3 > 0)
        {
            cont++;
        }
        if (n4 > 0)
        {
            cont++;
        }
        if (n5 > 0)
        {
            cont++;
        }
        if (n6 > 0)
        {
            cont++;
        }

        // Saída
        Console.WriteLine($"{cont} valores positivos");
    }
}