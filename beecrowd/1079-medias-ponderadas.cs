using System;
using System.Globalization;

class Bee1079
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i;
        double a, b, c, media;
        string[] valores;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            media = (a * 2 + b * 3 + c * 5) / 10.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}