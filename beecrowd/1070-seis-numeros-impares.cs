using System;

class Bee1070
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, n1, n2, n3, n4, n5, n6;

        // Entrada
        x = int.Parse(Console.ReadLine());

        // Condicional
        if (x % 2 == 0)
        {
            n1 = x + 1;
            n2 = x + 3; 
            n3 = x + 5;
            n4 = x + 7;
            n5 = x + 9;
            n6 = x + 11;
        }
        else
        {
            n1 = x;
            n2 = x + 2;
            n3 = x + 4;
            n4 = x + 6;
            n5 = x + 8;
            n6 = x + 10;
        }

        // Saída
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
    }
}