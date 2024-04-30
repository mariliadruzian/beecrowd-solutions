using System;

class Bee1132
{
    static void Main(string[] args)
    {
        // Variáveis
        int x, y, i;
        int maior, menor;
        int soma = 0;

        // Entrada
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        // Ordena do menor para o maior
        if (x > y)
        {
            maior = x;
            menor = y;
        }
        else
        {
            maior = y;
            menor = x;
        }

        // Saída
        for (i = menor; i <= maior; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}