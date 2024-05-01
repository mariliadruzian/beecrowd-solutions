using System;

class Bee1143
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i;
        int valor1 = 0;
        int valor2 = 0;
        int valor3 = 0;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            valor1 = i;
            valor2 = i * i;
            valor3 = i * i * i;
            Console.WriteLine($"{valor1} {valor2} {valor3}");
        }
    }
}