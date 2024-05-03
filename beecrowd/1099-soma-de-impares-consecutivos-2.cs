using System;

class Bee1099
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            int maior;
            int menor;
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

            int soma = 0;
            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}