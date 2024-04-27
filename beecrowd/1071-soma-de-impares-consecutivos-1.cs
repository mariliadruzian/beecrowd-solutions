using System;

class Bee1071
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, y, i, soma = 0;
        int menor, maior;

        // Entrada
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        // Ordena as entradas da maior para a menor
        if (x < y)
        {
            menor = x;
            maior = y;
        }
        else
        {
            menor = y;
            maior = x;
        }

        // Verifica os ímpares no intervalo e faz a adição na soma
        for (i = maior - 1; i > menor; i--)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        // Saída
        Console.WriteLine(soma);
    }
}