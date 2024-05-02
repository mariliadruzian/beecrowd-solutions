using System;

class Bee1153
{
    static void Main(string[] args)
    {
        int n, i; 
        int fatorial = 0;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i < n; i++)
        {
            if (i == 1)
            {
                fatorial = n * (n - i);
            }
            else
            {
                fatorial = fatorial * (n - i);
            }
        }

        Console.WriteLine(fatorial);
    }
}