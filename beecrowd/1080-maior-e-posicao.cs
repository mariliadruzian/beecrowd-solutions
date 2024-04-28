using System;

class Bee1080
{
    static void Main(string[] args)
    {
        int i, x;
        int posicao = 0;
        int max = 0;

        for (i = 1; i <= 100; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x > max)
            {
                max = x;
                posicao = i;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(posicao);
    }
}