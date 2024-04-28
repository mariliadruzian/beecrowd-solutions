using System;

class Bee1075
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i;

        // Entrada
        n = int.Parse(Console.ReadLine());
        
        // Saída
        for (i = 1; i <= 10000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}