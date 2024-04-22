using System;
using System.Globalization;

class Bee1117
{
    static void Main(string[] args)
    {
        // Variáveis
        double nota1, nota2, media;

        // Nota 1
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (nota1 < 0 || nota1 > 10)
        {
            Console.WriteLine("nota invalida");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        // Nota 2
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (nota2 < 0 || nota2 > 10)
        {
            Console.WriteLine("nota invalida");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        // Cálculo e saída da média
        media = (nota1 + nota2) / 2.0;
        Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}