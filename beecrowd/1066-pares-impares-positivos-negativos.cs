using System;

class Bee1066
{
    static void Main(string[] args)
    {
        // Variáveis
        int n1, n2, n3, n4, n5, totalPar = 0, totalImpar = 0, positivos = 0, negativos = 0;

        // Entrada
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());
        n5 = int.Parse(Console.ReadLine());

        // Condicional para verificar pares e ímpares
        if (n1 % 2 == 0)
        {
            totalPar++;
        }
        else
        {
            totalImpar++;
        }
        if (n2 % 2 == 0)
        {
            totalPar++;
        }
        else
        {
            totalImpar++;
        }
        if (n3 % 2 == 0)
        {
            totalPar++;
        }
        else
        {
            totalImpar++;
        }
        if (n4 % 2 == 0)
        {
            totalPar++;
        }
        else
        {
            totalImpar++;
        }
        if (n5 % 2 == 0)
        {
            totalPar++;
        }
        else
        {
            totalImpar++;
        }

        // Condicional para verificar positivos e negativos
        if (n1 > 0)
        {
            positivos++;
        }
        else if (n1 < 0)
        {
            negativos++;
        }
        if (n2 > 0)
        {
            positivos++;
        }
        else if (n2 < 0)
        {
            negativos++;
        }
        if (n3 > 0)
        {
            positivos++;
        }
        else if (n3 < 0)
        {
            negativos++;
        }
        if (n4 > 0)
        {
            positivos++;
        }
        else if (n4 < 0)
        {
            negativos++;
        }
        if (n5 > 0)
        {
            positivos++;
        }
        else if (n5 < 0)
        {
            negativos++;
        }

        // Saída
        Console.WriteLine($"{totalPar} valor(es) par(es)");
        Console.WriteLine($"{totalImpar} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");
    }
}