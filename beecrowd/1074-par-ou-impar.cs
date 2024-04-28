using System;

class Bee1074
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i, x;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (x > 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
            else
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}