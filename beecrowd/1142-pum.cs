using System;

class Bee1142
{
    static void Main(string[] args)
    {
        // Variáveis
        int i, n;
        int x = 0;
        int y = 0;
        int z = 0;

        // Entrada
        n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            n = int.Parse(Console.ReadLine());
        }

        // Saída
        for (i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                x = 1;
                y = 2;
                z = 3;
            }
            else
            {
                x += 4;
                y += 4;
                z += 4;
            }
            Console.WriteLine($"{x} {y} {z} PUM");
        }
    }
}