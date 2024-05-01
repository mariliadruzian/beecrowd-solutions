using System;

class Bee1144
{
    static void Main(string[] args)
    {
        // Variáveis
        int i, n;
        int valor1;
        int valor2;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            valor1 = i * i;
            valor2 = i * i * i;

            Console.WriteLine($"{i} {valor1} {valor2}");
            Console.WriteLine($"{i} {valor1 + 1} {valor2 + 1}");
        }
    }
}