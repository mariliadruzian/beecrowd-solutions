using System;

class Bee1101
{
    static void Main(string[] args)
    {
        // Variáveis
        int m, n, i;
        int maior;
        int menor;
        int soma = 0;

        // Entrada
        string[] valores = Console.ReadLine().Split(' ');
        m = int.Parse(valores[0]);
        n = int.Parse(valores[1]);

        // Estrutura condicional
        while (m > 0 && n > 0)
        {
            if (m > n)
            {
                maior = m;
                menor = n;
            }
            else
            {
                maior = n;
                menor = m;
            }

            for (i = menor; i <= maior; i++)
            {
                Console.Write($"{i} ");
                soma += i;
            }

            Console.WriteLine($"Sum={soma}");
            soma = 0;

            valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);
        }
    }
}