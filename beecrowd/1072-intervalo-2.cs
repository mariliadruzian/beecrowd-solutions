using System;

class Bee1072
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, x, i;
        int inTotal = 0;
        int outTotal = 0;

        // Entrada de 'n'
        n = int.Parse(Console.ReadLine());

        // Entrada de 'x'
        for (i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                inTotal++;
            }
            else
            {
                outTotal++;
            }
        }

        // Saída
        Console.WriteLine($"{inTotal} in");
        Console.WriteLine($"{outTotal} out");
    }
}