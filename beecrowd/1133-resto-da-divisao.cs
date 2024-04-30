using System;

class Bee1133
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, y, i;
        int maior, menor;

        // Entrada
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            maior = x;
            menor = y;
        }
        else
        {
            maior = y;
            menor = x;
        }

        // Saída
        for (i = menor + 1; i < maior; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}