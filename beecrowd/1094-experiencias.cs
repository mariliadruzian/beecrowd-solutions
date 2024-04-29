using System;
using System.Globalization;

class Bee1094
{
    static void Main(string[] args)
    {
        int n, i, qtde, total;
        int c = 0;
        int r = 0;
        int s = 0;
        double cPerc, rPerc, sPerc;
        char cobaia;
        string[] vet;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            vet = Console.ReadLine().Split(' ');
            qtde = int.Parse(vet[0]);
            cobaia = char.Parse(vet[1]);

            while (qtde < 1 || qtde > 15)
            {
                vet = Console.ReadLine().Split(' ');
                qtde = int.Parse(vet[0]);
                cobaia = char.Parse(vet[1]);
            }

            if (cobaia == 'C')
            {
                c += qtde;
            }
            else if (cobaia == 'R')
            {
                r += qtde;
            }
            else if (cobaia == 'S')
            {
                s += qtde;
            }
        }

        total = c + r + s;
        cPerc = (double)100 * c / total;
        rPerc = (double)100 * r / total;
        sPerc = (double)100 * s / total;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {c}");
        Console.WriteLine($"Total de ratos: {r}");
        Console.WriteLine($"Total de sapos: {s}");
        Console.WriteLine($"Percentual de coelhos: {cPerc.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {rPerc.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {sPerc.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
