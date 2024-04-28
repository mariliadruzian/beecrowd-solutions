using System;

class Bee1073
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i, resultado;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Validação da entrada (5 < N < 2000)
        while (n <= 5 || n >= 2000)
        {
            n = int.Parse(Console.ReadLine());
        }

        // Saída
        for (i = 2; i <= n; i += 2)
        {
            resultado = i * i;
            Console.WriteLine($"{i}^2 = {resultado}");
        }
    }
}