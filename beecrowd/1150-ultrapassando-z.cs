﻿using System;

class Bee1150
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        int cont = 0;
        for (int i = x; soma <= z; i++)
        {
            soma += i;
            cont++;
        }

        Console.WriteLine(cont);
    }
}