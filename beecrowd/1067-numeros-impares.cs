using System;

class Bee1067
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, i;

        // Entrada
        x = int.Parse(Console.ReadLine());

        // Valida a regra de entrada (1 <= X <= 1000)
        while (x < 1 || x > 1000)
        {
            x = int.Parse(Console.ReadLine());
        }

        // Saída
        for (i = 1; i <= x; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}