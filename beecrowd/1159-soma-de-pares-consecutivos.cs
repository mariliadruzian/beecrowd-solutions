﻿using System;

class Bee1159
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, soma;

        // Entrada
        x = int.Parse(Console.ReadLine());

        // Estrutura
        while (x != 0)
        {
            if (x % 2 == 0) // Define número par
            {
                soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                Console.WriteLine(soma);
            }
            else // Define número ímpar
            {
                x++;
                soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                Console.WriteLine(soma);
            }
            x = int.Parse(Console.ReadLine());
        }
    }
}