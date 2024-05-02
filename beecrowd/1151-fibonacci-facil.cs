using System;

class Bee1151
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i;
        int x = 0;
        int y = 1;
        int resultado;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            if (i > 1)
            {
                Console.Write(" ");
            }
            if (i == 1)
            {
                Console.Write("0");
            }
            if (i == 2)
            {
                Console.Write("1");
            }
            if (i >= 3)
            {
                resultado = x + y;
                Console.Write($"{resultado}");
                x = y;
                y = resultado;
            }
        }
    }
}