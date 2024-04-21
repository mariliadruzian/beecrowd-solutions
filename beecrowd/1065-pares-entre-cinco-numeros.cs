using System;

class Bee1065
{
    static void Main(string[] args)
    {
        // Variáveis
        int n1, n2, n3, n4, n5, cont = 0;

        // Entrada
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());
        n5 = int.Parse(Console.ReadLine());

        // Condicional
        if (n1 % 2 == 0) 
        {
            cont++;
        }
        if (n2 % 2 == 0) 
        {
            cont++;
        }
        if (n3 % 2 == 0) 
        {
            cont++;
        }
        if (n4 % 2 == 0) 
        {
            cont++;
        }
        if (n5 % 2 == 0) 
        {
            cont++;
        }

        // Saída
        Console.WriteLine($"{cont} valores pares");
    }
}